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
    /// Container for the parameters to the RestoreFromSnapshot operation. Restores a namespace
    /// from a snapshot.
    /// </summary>
    public partial class RestoreFromSnapshotRequest : AmazonRedshiftServerlessRequest
    {
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
        /// Gets and sets the property MaintainIntegration. 
        /// <para>
        /// If <c>true</c>, maintain existing data sharing, zero-ETL and S3 event integrations
        /// when restoring. Otherwise, integrations will not be maintained after the restore operation.
        /// Integrations are only maintained when restored to the same serverless namespace.
        /// </para>
        ///  
        /// <para>
        /// Default: true
        /// </para>
        /// </summary>
        public bool? MaintainIntegration { get; set; }

        /// <summary>
        /// Checks to see if the MaintainIntegration property is set.
        /// </summary>
        internal bool IsSetMaintainIntegration() => this.MaintainIntegration.HasValue;

        /// <summary>
        /// Gets and sets the property ManageAdminPassword. 
        /// <para>
        /// If <c>true</c>, Amazon Redshift uses Secrets Manager to manage the restored snapshot's
        /// admin credentials. If <c>MmanageAdminPassword</c> is false or not set, Amazon Redshift
        /// uses the admin credentials that the namespace or cluster had at the time the snapshot
        /// was taken.
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
        /// The name of the namespace to restore the snapshot to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The Amazon Web Services account that owns the snapshot.
        /// </para>
        /// </summary>
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot to restore from. Required if restoring
        /// from a provisioned cluster to Amazon Redshift Serverless. Must not be specified at
        /// the same time as <c>snapshotName</c>.
        /// </para>
        ///  
        /// <para>
        /// The format of the ARN is arn:aws:redshift:&lt;region&gt;:&lt;account_id&gt;:snapshot:&lt;cluster_identifier&gt;/&lt;snapshot_identifier&gt;.
        /// </para>
        /// </summary>
        public string SnapshotArn { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotArn property is set.
        /// </summary>
        internal bool IsSetSnapshotArn() => this.SnapshotArn != null;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the snapshot to restore from. Must not be specified at the same time as
        /// <c>snapshotArn</c>.
        /// </para>
        /// </summary>
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup used to restore the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string WorkgroupName { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupName property is set.
        /// </summary>
        internal bool IsSetWorkgroupName() => this.WorkgroupName != null;
    }
}
