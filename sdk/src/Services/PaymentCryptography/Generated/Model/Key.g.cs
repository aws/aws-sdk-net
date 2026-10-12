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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Metadata about an Amazon Web Services Payment Cryptography key.
    /// </summary>
    public partial class Key
    {
        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time when the key was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreateTimestamp property is set.
        /// </summary>
        internal bool IsSetCreateTimestamp() => this.CreateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DeletePendingTimestamp. 
        /// <para>
        /// The date and time after which Amazon Web Services Payment Cryptography will delete
        /// the key. This value is present only when <c>KeyState</c> is <c>DELETE_PENDING</c>
        /// and the key is scheduled for deletion.
        /// </para>
        /// </summary>
        public DateTime? DeletePendingTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DeletePendingTimestamp property is set.
        /// </summary>
        internal bool IsSetDeletePendingTimestamp() => this.DeletePendingTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteTimestamp. 
        /// <para>
        /// The date and time after which Amazon Web Services Payment Cryptography will delete
        /// the key. This value is present only when when the <c>KeyState</c> is <c>DELETE_COMPLETE</c>
        /// and the Amazon Web Services Payment Cryptography key is deleted.
        /// </para>
        /// </summary>
        public DateTime? DeleteTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DeleteTimestamp property is set.
        /// </summary>
        internal bool IsSetDeleteTimestamp() => this.DeleteTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DeriveKeyUsage. 
        /// <para>
        /// The cryptographic usage of an ECDH derived key as deﬁned in section A.5.2 of the TR-31
        /// spec.
        /// </para>
        /// </summary>
        public DeriveKeyUsage DeriveKeyUsage { get; set; }

        /// <summary>
        /// Checks to see if the DeriveKeyUsage property is set.
        /// </summary>
        internal bool IsSetDeriveKeyUsage() => this.DeriveKeyUsage != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the key is enabled. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Exportable. 
        /// <para>
        /// Specifies whether the key is exportable. This data is immutable after the key is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Exportable { get; set; }

        /// <summary>
        /// Checks to see if the Exportable property is set.
        /// </summary>
        internal bool IsSetExportable() => this.Exportable.HasValue;

        /// <summary>
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 70, Max = 150)]
        public string KeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KeyArn property is set.
        /// </summary>
        internal bool IsSetKeyArn() => this.KeyArn != null;

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// The role of the key, the algorithm it supports, and the cryptographic operations allowed
        /// with the key. This data is immutable after the key is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyAttributes KeyAttributes { get; set; }

        /// <summary>
        /// Checks to see if the KeyAttributes property is set.
        /// </summary>
        internal bool IsSetKeyAttributes() => this.KeyAttributes != null;

        /// <summary>
        /// Gets and sets the property KeyCheckValue. 
        /// <para>
        /// The key check value (KCV) is used to check if all parties holding a given key have
        /// the same key or to detect that a key has changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 16)]
        public string KeyCheckValue { get; set; }

        /// <summary>
        /// Checks to see if the KeyCheckValue property is set.
        /// </summary>
        internal bool IsSetKeyCheckValue() => this.KeyCheckValue != null;

        /// <summary>
        /// Gets and sets the property KeyCheckValueAlgorithm. 
        /// <para>
        /// The algorithm that Amazon Web Services Payment Cryptography uses to calculate the
        /// key check value (KCV). It is used to validate the key integrity.
        /// </para>
        ///  
        /// <para>
        /// For TDES keys, the KCV is computed by encrypting 8 bytes, each with value of zero,
        /// with the key to be checked and retaining the 3 highest order bytes of the encrypted
        /// result. For AES keys, the KCV is computed using a CMAC algorithm where the input data
        /// is 16 bytes of zero and retaining the 3 highest order bytes of the encrypted result.
        /// For HMAC keys, the KCV is computed using the hash selected at key creation on a zero-length
        /// message, taking the leftmost 3 bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyCheckValueAlgorithm KeyCheckValueAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyCheckValueAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyCheckValueAlgorithm() => this.KeyCheckValueAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyOrigin. 
        /// <para>
        /// The source of the key material. For keys created within Amazon Web Services Payment
        /// Cryptography, the value is <c>AWS_PAYMENT_CRYPTOGRAPHY</c>. For keys imported into
        /// Amazon Web Services Payment Cryptography, the value is <c>EXTERNAL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyOrigin KeyOrigin { get; set; }

        /// <summary>
        /// Checks to see if the KeyOrigin property is set.
        /// </summary>
        internal bool IsSetKeyOrigin() => this.KeyOrigin != null;

        /// <summary>
        /// Gets and sets the property KeyState. 
        /// <para>
        /// The state of key that is being created or deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyState KeyState { get; set; }

        /// <summary>
        /// Checks to see if the KeyState property is set.
        /// </summary>
        internal bool IsSetKeyState() => this.KeyState != null;

        /// <summary>
        /// Gets and sets the property MpaStatus. 
        /// <para>
        /// The Multi-Party Approval (MPA) status for the key, if applicable.
        /// </para>
        /// </summary>
        public MpaStatus MpaStatus { get; set; }

        /// <summary>
        /// Checks to see if the MpaStatus property is set.
        /// </summary>
        internal bool IsSetMpaStatus() => this.MpaStatus != null;

        /// <summary>
        /// Gets and sets the property MultiRegionKeyType. 
        /// <para>
        /// Indicates whether this key is a Multi-Region key and its role in the Multi-Region
        /// key hierarchy.
        /// </para>
        ///  
        /// <para>
        /// Multi-Region replication keys allow the same key material to be used across multiple
        /// Amazon Web Services Regions. This field specifies whether the key is a Primary Region
        /// key (PRK) (which can be replicated to other Amazon Web Services Regions) or a Replica
        /// Region key (RRK) (which is a copy of a PRK in another Region). For more information,
        /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-multi-region-replication.html">Multi-Region
        /// key replication</a>.
        /// </para>
        /// </summary>
        public MultiRegionKeyType MultiRegionKeyType { get; set; }

        /// <summary>
        /// Checks to see if the MultiRegionKeyType property is set.
        /// </summary>
        internal bool IsSetMultiRegionKeyType() => this.MultiRegionKeyType != null;

        /// <summary>
        /// Gets and sets the property PrimaryRegion.
        /// </summary>
        public string PrimaryRegion { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryRegion property is set.
        /// </summary>
        internal bool IsSetPrimaryRegion() => this.PrimaryRegion != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// Information about the replication status of the key across different Amazon Web Services
        /// Regions.
        /// </para>
        ///  
        /// <para>
        /// This field provides details about the current state of key replication, including
        /// any status messages or operational information. It helps track the progress and health
        /// of key replication operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ReplicationStatusType> ReplicationStatus { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ReplicationStatusType>() : null;

        /// <summary>
        /// Checks to see if the ReplicationStatus property is set.
        /// </summary>
        internal bool IsSetReplicationStatus() => this.ReplicationStatus != null && (this.ReplicationStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UsageStartTimestamp. 
        /// <para>
        /// The date and time after which Amazon Web Services Payment Cryptography will start
        /// using the key material for cryptographic operations.
        /// </para>
        /// </summary>
        public DateTime? UsageStartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UsageStartTimestamp property is set.
        /// </summary>
        internal bool IsSetUsageStartTimestamp() => this.UsageStartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property UsageStopTimestamp. 
        /// <para>
        /// The date and time after which Amazon Web Services Payment Cryptography will stop using
        /// the key material for cryptographic operations.
        /// </para>
        /// </summary>
        public DateTime? UsageStopTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UsageStopTimestamp property is set.
        /// </summary>
        internal bool IsSetUsageStopTimestamp() => this.UsageStopTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property UsingDefaultReplicationRegions. 
        /// <para>
        /// Indicates whether this key is using the account's default replication regions configuration
        /// for <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-multi-region-replication.html">Multi-Region
        /// key replication</a>.
        /// </para>
        ///  
        /// <para>
        /// When set to <c>true</c>, the key automatically replicates to the regions specified
        /// in the account's default replication settings. When set to <c>false</c>, the key has
        /// a custom replication configuration that overrides the account defaults.
        /// </para>
        /// </summary>
        public bool? UsingDefaultReplicationRegions { get; set; }

        /// <summary>
        /// Checks to see if the UsingDefaultReplicationRegions property is set.
        /// </summary>
        internal bool IsSetUsingDefaultReplicationRegions() => this.UsingDefaultReplicationRegions.HasValue;
    }
}
