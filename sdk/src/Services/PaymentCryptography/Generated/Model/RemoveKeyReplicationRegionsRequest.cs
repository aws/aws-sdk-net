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
    /// Container for the parameters to the RemoveKeyReplicationRegions operation.
    /// Removes Replication Regions from an existing Amazon Web Services Payment Cryptography
    /// key, disabling the key's availability for cryptographic operations in the specified
    /// Amazon Web Services Regions.
    /// 
    ///  
    /// <para>
    /// When you remove Replication Regions, the key material is securely deleted from those
    /// regions and can no longer be used for cryptographic operations there. This operation
    /// is irreversible for the specified Amazon Web Services Regions.
    /// </para>
    ///  
    /// <para>
    /// Ensure that no active cryptographic operations or applications depend on the key in
    /// the regions you're removing before performing this operation.
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
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_AddKeyReplicationRegions.html">AddKeyReplicationRegions</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DisableDefaultKeyReplicationRegions.html">DisableDefaultKeyReplicationRegions</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RemoveKeyReplicationRegionsRequest : AmazonPaymentCryptographyRequest
    {
        private string _keyIdentifier;
        private List<string> _replicationRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property KeyIdentifier. 
        /// <para>
        /// The key identifier (ARN or alias) of the key from which to remove replication regions.
        /// </para>
        ///  
        /// <para>
        /// This key must exist and have replication enabled in the specified regions.
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
        /// The list of Amazon Web Services Regions to remove from the key's replication configuration.
        /// </para>
        ///  
        /// <para>
        /// The key will no longer be available for cryptographic operations in these regions
        /// after removal. Ensure no active operations depend on the key in these regions before
        /// removal.
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