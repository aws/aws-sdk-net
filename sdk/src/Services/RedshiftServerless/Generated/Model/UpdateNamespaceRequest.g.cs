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
    /// Container for the parameters to the UpdateNamespace operation. Updates a namespace
    /// with the specified settings. Unless required, you can't update multiple parameters
    /// in one request. For example, you must specify both <c>adminUsername</c> and <c>adminUserPassword</c>
    /// to update either field, but you can't update both <c>kmsKeyId</c> and <c>logExports</c>
    /// in a single request. <para> Similarly, an S3 Tables log-publishing update (a request
    /// where <c>logDestinationType</c> is <c>s3table</c>) cannot be combined with any other
    /// namespace configuration change and must be submitted as its own request. </para>
    /// </summary>
    public partial class UpdateNamespaceRequest : AmazonRedshiftServerlessRequest
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
        /// This parameter must be updated together with <c>adminUsername</c>.
        /// </para>
        ///  
        /// <para>
        /// You can't use <c>adminUserPassword</c> if <c>manageAdminPassword</c> is true. 
        /// </para>
        ///  
        /// <para>
        /// If your admin user account is locked, this operation also unlocks your account and
        /// resets the failed-login counter. This option is available only when account lockout
        /// security is enabled for the namespace.
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
        /// This parameter must be updated together with <c>adminUserPassword</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AdminUsername { get; set; }

        /// <summary>
        /// Checks to see if the AdminUsername property is set.
        /// </summary>
        internal bool IsSetAdminUsername() => this.AdminUsername != null;

        /// <summary>
        /// Gets and sets the property DefaultIamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to set as a default in the namespace.
        /// This parameter must be updated together with <c>iamRoles</c>.
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
        /// A list of IAM roles to associate with the namespace. This parameter must be updated
        /// together with <c>defaultIamRoleArn</c>.
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
        /// Gets and sets the property LogDestinationType. 
        /// <para>
        /// The destination for the log data. Valid values are <c>s3table</c> and <c>cloudwatch</c>.
        /// </para>
        ///  
        /// <para>
        /// Set this to <c>s3table</c> to manage Amazon S3 Tables system-table publishing for
        /// the namespace.
        /// </para>
        /// </summary>
        public LogDestinationType LogDestinationType { get; set; }

        /// <summary>
        /// Checks to see if the LogDestinationType property is set.
        /// </summary>
        internal bool IsSetLogDestinationType() => this.LogDestinationType != null;

        /// <summary>
        /// Gets and sets the property LogExports. 
        /// <para>
        /// The types of logs the namespace can export. The export types are <c>userlog</c>, <c>connectionlog</c>,
        /// and <c>useractivitylog</c>.
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
        /// The name of the namespace to update. You can't update the name of a namespace once
        /// it is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property S3TableAction. 
        /// <para>
        /// Whether to enable or disable Amazon S3 Tables publishing. Valid values are <c>Enable</c>
        /// and <c>Disable</c>, matched case-insensitively.
        /// </para>
        ///  
        /// <para>
        /// When omitted, defaults to <c>Enable</c>. Valid only when <c>logDestinationType</c>
        /// is <c>s3table</c>.
        /// </para>
        /// </summary>
        public S3TableAction S3TableAction { get; set; }

        /// <summary>
        /// Checks to see if the S3TableAction property is set.
        /// </summary>
        internal bool IsSetS3TableAction() => this.S3TableAction != null;

        /// <summary>
        /// Gets and sets the property S3TableGranularity. 
        /// <para>
        /// The scope of the Amazon S3 Tables destination. Valid values are <c>namespace</c> and
        /// <c>account</c>, matched case-insensitively. <c>namespace</c> scopes the published
        /// tables to this namespace; <c>account</c> scopes them to the Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// Required when enabling. Omitting this parameter or passing a blank value fails with
        /// <c>ValidationException</c>. Valid only when <c>logDestinationType</c> is <c>s3table</c>.
        /// </para>
        /// </summary>
        public S3TableGranularity S3TableGranularity { get; set; }

        /// <summary>
        /// Checks to see if the S3TableGranularity property is set.
        /// </summary>
        internal bool IsSetS3TableGranularity() => this.S3TableGranularity != null;

        /// <summary>
        /// Gets and sets the property S3TableKmsKeyId. 
        /// <para>
        /// The identifier of the Key Management Service key used to encrypt the published Amazon
        /// S3 Tables data. When omitted, the data is encrypted with SSE-S3 (Amazon S3 managed
        /// keys).
        /// </para>
        ///  
        /// <para>
        /// Valid only when <c>logDestinationType</c> is <c>s3table</c>.
        /// </para>
        /// </summary>
        public string S3TableKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the S3TableKmsKeyId property is set.
        /// </summary>
        internal bool IsSetS3TableKmsKeyId() => this.S3TableKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property S3TableNames. 
        /// <para>
        /// The system tables to publish (on enable) or to stop publishing (on disable). Each
        /// value is either a system table view name that begins with <c>sys_</c> or the keyword
        /// <c>all</c>.
        /// </para>
        ///  
        /// <para>
        /// Omitting this parameter, passing an empty list, or including <c>all</c> each select
        /// every current and future system table. Each name must be 1-128 characters, and the
        /// list can contain up to 256 names.
        /// </para>
        ///  
        /// <para>
        /// Valid only when <c>logDestinationType</c> is <c>s3table</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public List<string> S3TableNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the S3TableNames property is set.
        /// </summary>
        internal bool IsSetS3TableNames() => this.S3TableNames != null && (this.S3TableNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
