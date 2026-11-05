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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Metadata associated with received licenses and grants.
    /// </summary>
    public partial class ReceivedMetadata
    {
        /// <summary>
        /// Gets and sets the property AllowedOperations. 
        /// <para>
        /// Allowed operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8)]
        public List<string> AllowedOperations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedOperations property is set.
        /// </summary>
        internal bool IsSetAllowedOperations() => this.AllowedOperations != null && (this.AllowedOperations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// The type of the grant through which the license was received. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BuyerGrant</c> - Grants you the entitlement to use the license.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DelegateGrant</c> - Gives you read-only visibility into the licenses and grants
        /// distributed to buyers, with no entitlement to use them.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GrantType GrantType { get; set; }

        /// <summary>
        /// Checks to see if the GrantType property is set.
        /// </summary>
        internal bool IsSetGrantType() => this.GrantType != null;

        /// <summary>
        /// Gets and sets the property ReceivedStatus. 
        /// <para>
        /// Received status.
        /// </para>
        /// </summary>
        public ReceivedStatus ReceivedStatus { get; set; }

        /// <summary>
        /// Checks to see if the ReceivedStatus property is set.
        /// </summary>
        internal bool IsSetReceivedStatus() => this.ReceivedStatus != null;

        /// <summary>
        /// Gets and sets the property ReceivedStatusReason. 
        /// <para>
        /// Received status reason.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 400)]
        public string ReceivedStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the ReceivedStatusReason property is set.
        /// </summary>
        internal bool IsSetReceivedStatusReason() => this.ReceivedStatusReason != null;
    }
}
