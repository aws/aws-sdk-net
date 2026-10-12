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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// Configuration for Amazon Web Services Security Token Service (STS) access from the
    /// ODB network.
    /// </summary>
    public partial class StsAccess
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name for Amazon Web Services Security Token Service (STS) access configuration.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Ipv4Addresses. 
        /// <para>
        /// The IPv4 addresses allowed for Amazon Web Services Security Token Service (STS) access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public List<string> Ipv4Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Ipv4Addresses property is set.
        /// </summary>
        internal bool IsSetIpv4Addresses() => this.Ipv4Addresses != null && (this.Ipv4Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Amazon Web Services Security Token Service (STS) access
        /// configuration.
        /// </para>
        /// </summary>
        public ManagedResourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StsPolicyDocument. 
        /// <para>
        /// The Amazon Web Services Security Token Service (STS) policy document that defines
        /// permissions for token service usage.
        /// </para>
        /// </summary>
        public string StsPolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the StsPolicyDocument property is set.
        /// </summary>
        internal bool IsSetStsPolicyDocument() => this.StsPolicyDocument != null;
    }
}
