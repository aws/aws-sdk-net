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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the CreateNamespace operation. Creates a namespace
    /// in Amazon Redshift Serverless.
    /// </summary>
    public partial class CreateNamespaceRequest : AmazonRedshiftServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property AdminPasswordSecretKmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt and store the namespace's
        /// admin credentials secret. You can only use this parameter if <c>manageAdminPassword</c>
        /// is true.
        /// </para>
        /// </summary>
        public string AdminPasswordSecretKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AdminPasswordSecretKmsKeyId property is set.
        /// </summary>
        internal bool IsSetAdminPasswordSecretKmsKeyId() => this.AdminPasswordSecretKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property AdminUserPassword. 
        /// <para>
        /// The password of the administrator for the first database created in the namespace.
        /// </para>
        ///  
        /// <para>
        /// You can't use <c>adminUserPassword</c> if <c>manageAdminPassword</c> is true. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AdminUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the AdminUserPassword property is set.
        /// </summary>
        internal bool IsSetAdminUserPassword() => this.AdminUserPassword != null;

        /// <summary>
        /// Gets and sets the property AdminUsername. 
        /// <para>
        /// The username of the administrator for the first database created in the namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AdminUsername { get; set; }

        /// <summary>
        /// Checks to see if the AdminUsername property is set.
        /// </summary>
        internal bool IsSetAdminUsername() => this.AdminUsername != null;

        /// <summary>
        /// Gets and sets the property DbName. 
        /// <para>
        /// The name of the first database created in the namespace.
        /// </para>
        /// </summary>
        public string DbName { get; set; }

        /// <summary>
        /// Checks to see if the DbName property is set.
        /// </summary>
        internal bool IsSetDbName() => this.DbName != null;

        /// <summary>
        /// Gets and sets the property DefaultIamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to set as a default in the namespace.
        /// </para>
        /// </summary>
        public string DefaultIamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DefaultIamRoleArn property is set.
        /// </summary>
        internal bool IsSetDefaultIamRoleArn() => this.DefaultIamRoleArn != null;

        /// <summary>
        /// Gets and sets the property IamRoles. 
        /// <para>
        /// A list of IAM roles to associate with the namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IamRoles { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IamRoles property is set.
        /// </summary>
        internal bool IsSetIamRoles() => this.IamRoles != null && (this.IamRoles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Amazon Web Services Key Management Service key used to encrypt your
        /// data.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LogExports. 
        /// <para>
        /// The types of logs the namespace can export. Available export types are <c>userlog</c>,
        /// <c>connectionlog</c>, and <c>useractivitylog</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public List<string> LogExports { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogExports property is set.
        /// </summary>
        internal bool IsSetLogExports() => this.LogExports != null && (this.LogExports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ManageAdminPassword. 
        /// <para>
        /// If <c>true</c>, Amazon Redshift uses Secrets Manager to manage the namespace's admin
        /// credentials. You can't use <c>adminUserPassword</c> if <c>manageAdminPassword</c>
        /// is true. If <c>manageAdminPassword</c> is false or not set, Amazon Redshift uses <c>adminUserPassword</c>
        /// for the admin user account's password. 
        /// </para>
        /// </summary>
        public bool? ManageAdminPassword { get; set; }

        /// <summary>
        /// Checks to see if the ManageAdminPassword property is set.
        /// </summary>
        internal bool IsSetManageAdminPassword() => this.ManageAdminPassword.HasValue;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property RedshiftIdcApplicationArn. 
        /// <para>
        /// The ARN for the Redshift application that integrates with IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RedshiftIdcApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftIdcApplicationArn property is set.
        /// </summary>
        internal bool IsSetRedshiftIdcApplicationArn() => this.RedshiftIdcApplicationArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
