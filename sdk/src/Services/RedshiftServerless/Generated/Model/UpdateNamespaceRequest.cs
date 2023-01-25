/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNamespace operation.
    /// Updates a namespace with the specified settings. Unless required, you can't update
    /// multiple parameters in one request. For example, you must specify both <code>adminUsername</code>
    /// and <code>adminUserPassword</code> to update either field, but you can't update both
    /// <code>kmsKeyId</code> and <code>logExports</code> in a single request.
    /// </summary>
    public partial class UpdateNamespaceRequest : AmazonRedshiftServerlessRequest
    {
        private string _adminUsername;
        private string _adminUserPassword;
        private string _defaultIamRoleArn;
        private List<string> _iamRoles = new List<string>();
        private string _kmsKeyId;
        private List<string> _logExports = new List<string>();
        private string _namespaceName;

        /// <summary>
        /// Gets and sets the property AdminUsername. 
        /// <para>
        /// The username of the administrator for the first database created in the namespace.
        /// This parameter must be updated together with <code>adminUserPassword</code>.
        /// </para>
        /// </summary>
        public string AdminUsername
        {
            get { return this._adminUsername; }
            set { this._adminUsername = value; }
        }

        // Check to see if AdminUsername property is set
        internal bool IsSetAdminUsername()
        {
            return this._adminUsername != null;
        }

        /// <summary>
        /// Gets and sets the property AdminUserPassword. 
        /// <para>
        /// The password of the administrator for the first database created in the namespace.
        /// This parameter must be updated together with <code>adminUsername</code>.
        /// </para>
        /// </summary>
        public string AdminUserPassword
        {
            get { return this._adminUserPassword; }
            set { this._adminUserPassword = value; }
        }

        // Check to see if AdminUserPassword property is set
        internal bool IsSetAdminUserPassword()
        {
            return this._adminUserPassword != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultIamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to set as a default in the namespace.
        /// This parameter must be updated together with <code>iamRoles</code>.
        /// </para>
        /// </summary>
        public string DefaultIamRoleArn
        {
            get { return this._defaultIamRoleArn; }
            set { this._defaultIamRoleArn = value; }
        }

        // Check to see if DefaultIamRoleArn property is set
        internal bool IsSetDefaultIamRoleArn()
        {
            return this._defaultIamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoles. 
        /// <para>
        /// A list of IAM roles to associate with the namespace. This parameter must be updated
        /// together with <code>defaultIamRoleArn</code>.
        /// </para>
        /// </summary>
        public List<string> IamRoles
        {
            get { return this._iamRoles; }
            set { this._iamRoles = value; }
        }

        // Check to see if IamRoles property is set
        internal bool IsSetIamRoles()
        {
            return this._iamRoles != null && this._iamRoles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Amazon Web Services Key Management Service key used to encrypt your
        /// data.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LogExports. 
        /// <para>
        /// The types of logs the namespace can export. The export types are <code>userlog</code>,
        /// <code>connectionlog</code>, and <code>useractivitylog</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public List<string> LogExports
        {
            get { return this._logExports; }
            set { this._logExports = value; }
        }

        // Check to see if LogExports property is set
        internal bool IsSetLogExports()
        {
            return this._logExports != null && this._logExports.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace to update. You can't update the name of a namespace once
        /// it is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

    }
}