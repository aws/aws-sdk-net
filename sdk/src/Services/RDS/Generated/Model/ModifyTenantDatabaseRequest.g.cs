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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyTenantDatabase operation. Modifies an existing
    /// tenant database in a DB instance. You can change the tenant database name or the master
    /// user password. This operation is supported only for RDS for Oracle CDB instances using
    /// the multi-tenant configuration.
    /// </summary>
    public partial class ModifyTenantDatabaseRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property DBInstanceIdentifier. 
        /// <para>
        /// The identifier of the DB instance that contains the tenant database that you are modifying.
        /// This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DB instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifier() => this.DBInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ManageMasterUserPassword. 
        /// <para>
        /// Specifies whether to manage the master user password with Amazon Web Services Secrets
        /// Manager.
        /// </para>
        ///  
        /// <para>
        /// If the tenant database doesn't manage the master user password with Amazon Web Services
        /// Secrets Manager, you can turn on this management. In this case, you can't specify
        /// <c>MasterUserPassword</c>.
        /// </para>
        ///  
        /// <para>
        /// If the tenant database already manages the master user password with Amazon Web Services
        /// Secrets Manager, and you specify that the master user password is not managed with
        /// Amazon Web Services Secrets Manager, then you must specify <c>MasterUserPassword</c>.
        /// In this case, Amazon RDS deletes the secret and uses the new password for the master
        /// user specified by <c>MasterUserPassword</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon RDS User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't manage the master user password with Amazon Web Services Secrets Manager if
        /// <c>MasterUserPassword</c> is specified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? ManageMasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the ManageMasterUserPassword property is set.
        /// </summary>
        internal bool IsSetManageMasterUserPassword() => this.ManageMasterUserPassword.HasValue;

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The new password for the master user of the specified tenant database in your DB instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon RDS operations never return the password, so this action provides a way to
        /// regain access to a tenant database user if the password is lost. This includes restoring
        /// privileges that might have been accidentally revoked.
        /// </para>
        ///  </note> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can include any printable ASCII character except <c>/</c>, <c>"</c> (double quote),
        /// <c>@</c>, <c>&amp;</c> (ampersand), and <c>'</c> (single quote).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Length constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain between 8 and 30 characters. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string MasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserPassword property is set.
        /// </summary>
        internal bool IsSetMasterUserPassword() => this.MasterUserPassword != null;

        /// <summary>
        /// Gets and sets the property MasterUserSecretKmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier to encrypt a secret that is automatically
        /// generated and managed in Amazon Web Services Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// This setting is valid only if both of the following conditions are met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The tenant database doesn't manage the master user password in Amazon Web Services
        /// Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// If the tenant database already manages the master user password in Amazon Web Services
        /// Secrets Manager, you can't change the KMS key used to encrypt the secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You're turning on <c>ManageMasterUserPassword</c> to manage the master user password
        /// in Amazon Web Services Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// If you're turning on <c>ManageMasterUserPassword</c> and don't specify <c>MasterUserSecretKmsKeyId</c>,
        /// then the <c>aws/secretsmanager</c> KMS key is used to encrypt the secret. If the secret
        /// is in a different Amazon Web Services account, then you can't use the <c>aws/secretsmanager</c>
        /// KMS key to encrypt the secret, and you must use a self-managed KMS key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The Amazon Web Services KMS key identifier is any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ARN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name for the KMS key
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use a KMS key in a different Amazon Web Services account, specify the key ARN or
        /// alias ARN.
        /// </para>
        ///  
        /// <para>
        /// A default KMS key exists for your Amazon Web Services account. Your Amazon Web Services
        /// account has a different default KMS key for each Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string MasterUserSecretKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserSecretKmsKeyId property is set.
        /// </summary>
        internal bool IsSetMasterUserSecretKmsKeyId() => this.MasterUserSecretKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property NewTenantDBName. 
        /// <para>
        /// The new name of the tenant database when renaming a tenant database. This parameter
        /// isn’t case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Can't be the string null or any other reserved word.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be longer than 8 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string NewTenantDBName { get; set; }

        /// <summary>
        /// Checks to see if the NewTenantDBName property is set.
        /// </summary>
        internal bool IsSetNewTenantDBName() => this.NewTenantDBName != null;

        /// <summary>
        /// Gets and sets the property RotateMasterUserPassword. 
        /// <para>
        /// Specifies whether to rotate the secret managed by Amazon Web Services Secrets Manager
        /// for the master user password.
        /// </para>
        ///  
        /// <para>
        /// This setting is valid only if the master user password is managed by RDS in Amazon
        /// Web Services Secrets Manager for the DB instance. The secret value contains the updated
        /// password.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-secrets-manager.html">Password
        /// management with Amazon Web Services Secrets Manager</a> in the <i>Amazon RDS User
        /// Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must apply the change immediately when rotating the master user password.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? RotateMasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the RotateMasterUserPassword property is set.
        /// </summary>
        internal bool IsSetRotateMasterUserPassword() => this.RotateMasterUserPassword.HasValue;

        /// <summary>
        /// Gets and sets the property TenantDBName. 
        /// <para>
        /// The user-supplied name of the tenant database that you want to modify. This parameter
        /// isn’t case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing tenant database.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TenantDBName { get; set; }

        /// <summary>
        /// Checks to see if the TenantDBName property is set.
        /// </summary>
        internal bool IsSetTenantDBName() => this.TenantDBName != null;
    }
}
