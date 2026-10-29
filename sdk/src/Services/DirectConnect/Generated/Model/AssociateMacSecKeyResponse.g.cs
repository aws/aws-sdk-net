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
    /// This is the response object from the AssociateMacSecKey operation.
    /// </summary>
    public partial class AssociateMacSecKeyResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the dedicated connection (dxcon-xxxx), interconnect (dxcon-xxxx), or LAG
        /// (dxlag-xxxx).
        /// </para>
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

        /// <summary>
        /// Gets and sets the property MacSecKeys. 
        /// <para>
        /// The MAC Security (MACsec) security keys associated with the connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MacSecKey> MacSecKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<MacSecKey>() : null;

        /// <summary>
        /// Checks to see if the MacSecKeys property is set.
        /// </summary>
        internal bool IsSetMacSecKeys() => this.MacSecKeys != null && (this.MacSecKeys.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
