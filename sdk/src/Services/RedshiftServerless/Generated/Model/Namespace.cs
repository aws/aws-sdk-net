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
    /// A collection of database objects and users.
    /// </summary>
    public partial class Namespace
    {
        private string _adminPasswordSecretArn;
        private string _adminPasswordSecretKmsKeyId;
        private string _adminUsername;
        private DateTime? _creationDate;
        private string _dbName;
        private string _defaultIamRoleArn;
        private List<string> _iamRoles = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _kmsKeyId;
        private List<string> _logExports = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _namespaceArn;
        private string _namespaceId;
        private string _namespaceName;
        private NamespaceStatus _status;

        /// <summary>
        /// Gets and sets the property AdminPasswordSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the namespace's admin user credentials secret.
        /// </para>
        /// </summary>
        public string AdminPasswordSecretArn
        {
            get { return this._adminPasswordSecretArn; }
            set { this._adminPasswordSecretArn = value; }
        }

        // Check to see if AdminPasswordSecretArn property is set
        internal bool IsSetAdminPasswordSecretArn()
        {
            return this._adminPasswordSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property AdminPasswordSecretKmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt and store the namespace's
        /// admin credentials secret.
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date of when the namespace was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbName. 
        /// <para>
        /// The name of the first database created in the namespace.
        /// </para>
        /// </summary>
        public string DbName
        {
            get { return this._dbName; }
            set { this._dbName = value; }
        }

        // Check to see if DbName property is set
        internal bool IsSetDbName()
        {
            return this._dbName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultIamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to set as a default in the namespace.
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
        /// A list of IAM roles to associate with the namespace.
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
        /// The types of logs the namespace can export. Available export types are User log, Connection
        /// log, and User activity log.
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
        /// Gets and sets the property NamespaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with a namespace.
        /// </para>
        /// </summary>
        public string NamespaceArn
        {
            get { return this._namespaceArn; }
            set { this._namespaceArn = value; }
        }

        // Check to see if NamespaceArn property is set
        internal bool IsSetNamespaceArn()
        {
            return this._namespaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceId. 
        /// <para>
        /// The unique identifier of a namespace.
        /// </para>
        /// </summary>
        public string NamespaceId
        {
            get { return this._namespaceId; }
            set { this._namespaceId = value; }
        }

        // Check to see if NamespaceId property is set
        internal bool IsSetNamespaceId()
        {
            return this._namespaceId != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace. Must be between 3-64 alphanumeric characters in lowercase,
        /// and it cannot be a reserved word. A list of reserved words can be found in <a href="https://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved
        /// Words</a> in the Amazon Redshift Database Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the namespace.
        /// </para>
        /// </summary>
        public NamespaceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}