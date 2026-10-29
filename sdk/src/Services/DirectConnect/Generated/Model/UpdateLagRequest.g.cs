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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLag operation. Updates the attributes of
    /// the specified link aggregation group (LAG). <para> You can update the following LAG
    /// attributes: </para> <ul> <li> <para> The name of the LAG. </para> </li> <li> <para>
    /// The value for the minimum number of connections that must be operational for the LAG
    /// itself to be operational. </para> </li> <li> <para> The LAG's MACsec encryption mode.
    /// </para> <para> Amazon Web Services assigns this value to each connection which is
    /// part of the LAG. </para> </li> <li> <para> The tags </para> </li> </ul> <note> <para>
    /// If you adjust the threshold value for the minimum number of operational connections,
    /// ensure that the new value does not cause the LAG to fall below the threshold and become
    /// non-operational. </para> </note>
    /// </summary>
    public partial class UpdateLagRequest : AmazonDirectConnectRequest
    {
        /// <summary>
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        /// The LAG MAC Security (MACsec) encryption mode.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services applies the value to all connections which are part of the LAG.
        /// </para>
        /// </summary>
        public string EncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionMode property is set.
        /// </summary>
        internal bool IsSetEncryptionMode() => this.EncryptionMode != null;

        /// <summary>
        /// Gets and sets the property LagId. 
        /// <para>
        /// The ID of the LAG.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LagId { get; set; }

        /// <summary>
        /// Checks to see if the LagId property is set.
        /// </summary>
        internal bool IsSetLagId() => this.LagId != null;

        /// <summary>
        /// Gets and sets the property LagName. 
        /// <para>
        /// The name of the LAG.
        /// </para>
        /// </summary>
        public string LagName { get; set; }

        /// <summary>
        /// Checks to see if the LagName property is set.
        /// </summary>
        internal bool IsSetLagName() => this.LagName != null;

        /// <summary>
        /// Gets and sets the property MinimumLinks. 
        /// <para>
        /// The minimum number of physical connections that must be operational for the LAG itself
        /// to be operational.
        /// </para>
        /// </summary>
        public int? MinimumLinks { get; set; }

        /// <summary>
        /// Checks to see if the MinimumLinks property is set.
        /// </summary>
        internal bool IsSetMinimumLinks() => this.MinimumLinks.HasValue;
    }
}
