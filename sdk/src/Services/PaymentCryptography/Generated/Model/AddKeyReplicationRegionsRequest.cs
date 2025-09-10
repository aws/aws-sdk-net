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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
    /// Container for the parameters to the AddKeyReplicationRegions operation.
    /// Adds replication Amazon Web Services Regions to an existing Amazon Web Services Payment
    /// Cryptography key, enabling the key to be used for cryptographic operations in additional
    /// Amazon Web Services Regions.
    /// 
    ///  
    /// <para>
    /// Multi-region keys allow you to use the same key material across multiple Amazon Web
    /// Services Regions, providing lower latency for applications distributed across regions.
    /// When you add Replication Regions, Amazon Web Services Payment Cryptography securely
    /// replicates the key material to the specified Amazon Web Services Regions.
    /// </para>
    ///  
    /// <para>
    /// The key must be in an active state to add Replication Regions. You can add multiple
    /// regions in a single operation, and the key will be available for use in those regions
    /// once replication is complete.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
    /// Services accounts.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_RemoveKeyReplicationRegions.html">RemoveKeyReplicationRegions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_EnableDefaultKeyReplicationRegions.html">EnableDefaultKeyReplicationRegions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetDefaultKeyReplicationRegions.html">GetDefaultKeyReplicationRegions</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AddKeyReplicationRegionsRequest : AmazonPaymentCryptographyRequest
    {
        private string _keyIdentifier;
        private List<string> _replicationRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The key identifier (ARN or alias) of the key for which to add replication regions.
        /// </para>
        ///  
        /// <para>
        /// This key must exist and be in a valid state for replication operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string KeyIdentifier
        {
            get { return this._keyIdentifier; }
            set { this._keyIdentifier = value; }
        }

        // Check to see if KeyIdentifier property is set
        internal bool IsSetKeyIdentifier()
        {
            return this._keyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationRegions. 
        /// <para>
        /// The list of Amazon Web Services Regions to add to the key's replication configuration.
        /// </para>
        ///  
        /// <para>
        /// Each region must be a valid Amazon Web Services Region where Amazon Web Services Payment
        /// Cryptography is available. The key will be replicated to these regions, allowing cryptographic
        /// operations to be performed closer to your applications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ReplicationRegions
        {
            get { return this._replicationRegions; }
            set { this._replicationRegions = value; }
        }

        // Check to see if ReplicationRegions property is set
        internal bool IsSetReplicationRegions()
        {
            return this._replicationRegions != null && (this._replicationRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}