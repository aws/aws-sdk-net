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
    /// A collection of database objects and users.
    /// </summary>
    public partial class Namespace
    {
        /// <summary>
        /// Gets and sets the property AdminPasswordSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the namespace's admin user credentials secret.
        /// </para>
        /// </summary>
        public string AdminPasswordSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the AdminPasswordSecretArn property is set.
        /// </summary>
        internal bool IsSetAdminPasswordSecretArn() => this.AdminPasswordSecretArn != null;

        /// <summary>
        /// Gets and sets the property AdminPasswordSecretKmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt and store the namespace's
        /// admin credentials secret.
        /// </para>
        /// </summary>
        public string AdminPasswordSecretKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AdminPasswordSecretKmsKeyId property is set.
        /// </summary>
        internal bool IsSetAdminPasswordSecretKmsKeyId() => this.AdminPasswordSecretKmsKeyId != null;

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
        /// Gets and sets the property CatalogArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Glue Data Catalog associated with the namespace
        /// enabled with Amazon Redshift federated permissions.
        /// </para>
        /// </summary>
        public string CatalogArn { get; set; }

        /// <summary>
        /// Checks to see if the CatalogArn property is set.
        /// </summary>
        internal bool IsSetCatalogArn() => this.CatalogArn != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date of when the namespace was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

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
        /// Gets and sets the property LakehouseRegistrationStatus. 
        /// <para>
        /// The status of the lakehouse registration for the namespace. Indicates whether the
        /// namespace is successfully registered with Amazon Redshift federated permissions.
        /// </para>
        /// </summary>
        public string LakehouseRegistrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the LakehouseRegistrationStatus property is set.
        /// </summary>
        internal bool IsSetLakehouseRegistrationStatus() => this.LakehouseRegistrationStatus != null;

        /// <summary>
        /// Gets and sets the property LogExports. 
        /// <para>
        /// The types of logs the namespace can export. Available export types are User log, Connection
        /// log, and User activity log.
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
        /// Gets and sets the property NamespaceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with a namespace.
        /// </para>
        /// </summary>
        public string NamespaceArn { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceArn property is set.
        /// </summary>
        internal bool IsSetNamespaceArn() => this.NamespaceArn != null;

        /// <summary>
        /// Gets and sets the property NamespaceId. 
        /// <para>
        /// The unique identifier of a namespace.
        /// </para>
        /// </summary>
        public string NamespaceId { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceId property is set.
        /// </summary>
        internal bool IsSetNamespaceId() => this.NamespaceId != null;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace. Must be between 3-64 alphanumeric characters in lowercase,
        /// and it cannot be a reserved word. A list of reserved words can be found in <a href="https://docs.aws.amazon.com/redshift/latest/dg/r_pg_keywords.html">Reserved
        /// Words</a> in the Amazon Redshift Database Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property S3TablePublishStatus. 
        /// <para>
        /// The current Amazon S3 Tables log-publishing status for the namespace. Not returned
        /// when S3 Tables publishing has never been configured for the namespace.
        /// </para>
        /// </summary>
        public S3TablePublishStatus S3TablePublishStatus { get; set; }

        /// <summary>
        /// Checks to see if the S3TablePublishStatus property is set.
        /// </summary>
        internal bool IsSetS3TablePublishStatus() => this.S3TablePublishStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the namespace.
        /// </para>
        /// </summary>
        public NamespaceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
