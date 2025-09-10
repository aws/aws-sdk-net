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
    /// Container for the parameters to the DisableDefaultKeyReplicationRegions operation.
    /// Disables multi-region key replication settings for the specified Amazon Web Services
    /// Regions in your account, preventing new keys from being automatically replicated to
    /// those regions.
    /// 
    ///  
    /// <para>
    /// After disabling default replication for specific regions, new keys created in your
    /// account will not be automatically replicated to those regions. You can still manually
    /// add replication to those regions for individual keys using the AddKeyReplicationRegions
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// This operation does not affect existing keys or their current replication configuration.
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
    public partial class DisableDefaultKeyReplicationRegionsRequest : AmazonPaymentCryptographyRequest
    {
        private List<string> _replicationRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ReplicationRegions. 
        /// <para>
        /// The list of Amazon Web Services Regions to remove from the account's default replication
        /// regions.
        /// </para>
        ///  
        /// <para>
        /// New keys created after this operation will not automatically be replicated to these
        /// regions, though existing keys with replication to these regions will be unaffected.
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