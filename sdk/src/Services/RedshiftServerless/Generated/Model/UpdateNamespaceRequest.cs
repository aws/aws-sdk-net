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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNamespace operation.
    /// Updates a namespace with the specified settings. Unless required, you can't update
    /// multiple parameters in one request. For example, you must specify both <c>adminUsername</c>
    /// and <c>adminUserPassword</c> to update either field, but you can't update both <c>kmsKeyId</c>
    /// and <c>logExports</c> in a single request.
    /// </summary>
    public partial class UpdateNamespaceRequest : AmazonRedshiftServerlessRequest
    {
        private string _adminPasswordSecretKmsKeyId;
        private string _adminUsername;
        private string _adminUserPassword;
        private string _defaultIamRoleArn;
        private List<string> _iamRoles = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _kmsKeyId;
        private List<string> _logExports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _manageAdminPassword;
        private string _namespaceName;

        /// <summary>
        /// Gets and sets the property AdminPasswordSecretKmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt and store the namespace's
        /// admin credentials secret. You can only use this parameter if <c>manageAdminPassword</c>
        /// is true.
        /// </para>
        /// </summary>
        public string AdminPasswordSecretKmsKeyId
        {
            get { return this._adminPasswordSecretKmsKeyId; }
            set { this._adminPasswordSecretKmsKeyId = value; }
        }

        // Check to see if AdminPasswordSecretKmsKeyId property is set
        internal bool IsSetAdminPasswordSecretKmsKeyId()
        {
            return this._adminPasswordSecretKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property AdminUsername. 
        /// <para>
        /// The username of the administrator for the first database created in the namespace.
        /// This parameter must be updated together with <c>adminUserPassword</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// This parameter must be updated together with <c>adminUsername</c>.
        /// </para>
        ///  
        /// <para>
        /// You can't use <c>adminUserPassword</c> if <c>manageAdminPassword</c> is true. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// This parameter must be updated together with <c>iamRoles</c>.
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
        /// together with <c>defaultIamRoleArn</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IamRoles
        {
            get { return this._iamRoles; }
            set { this._iamRoles = value; }
        }

        // Check to see if IamRoles property is set
        internal bool IsSetIamRoles()
        {
            return this._iamRoles != null && (this._iamRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The types of logs the namespace can export. The export types are <c>userlog</c>, <c>connectionlog</c>,
        /// and <c>useractivitylog</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._logExports != null && (this._logExports.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ManageAdminPassword. 
        /// <para>
        /// If <c>true</c>, Amazon Redshift uses Secrets Manager to manage the namespace's admin
        /// credentials. You can't use <c>adminUserPassword</c> if <c>manageAdminPassword</c>
        /// is true. If <c>manageAdminPassword</c> is false or not set, Amazon Redshift uses <c>adminUserPassword</c>
        /// for the admin user account's password. 
        /// </para>
        /// </summary>
        public bool? ManageAdminPassword
        {
            get { return this._manageAdminPassword; }
            set { this._manageAdminPassword = value; }
        }

        // Check to see if ManageAdminPassword property is set
        internal bool IsSetManageAdminPassword()
        {
            return this._manageAdminPassword.HasValue; 
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