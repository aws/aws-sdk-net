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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateAvailabilityZones operation. Associates
    /// the specified Availability Zones with a transit gateway-attached firewall. For each
    /// Availability Zone, Network Firewall creates a firewall endpoint to process traffic.
    /// You can specify one or more Availability Zones where you want to deploy the firewall.
    /// <para> After adding Availability Zones, you must update your transit gateway route
    /// tables to direct traffic through the new firewall endpoints. Use <a>DescribeFirewall</a>
    /// to monitor the status of the new endpoints. </para>
    /// </summary>
    public partial class AssociateAvailabilityZonesRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZoneMappings. 
        /// <para>
        /// Required. The Availability Zones where you want to create firewall endpoints. You
        /// must specify at least one Availability Zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AvailabilityZoneMapping> AvailabilityZoneMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailabilityZoneMapping>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZoneMappings property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneMappings() => this.AvailabilityZoneMappings != null && (this.AvailabilityZoneMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirewallArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the firewall.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FirewallArn { get; set; }

        /// <summary>
        /// Checks to see if the FirewallArn property is set.
        /// </summary>
        internal bool IsSetFirewallArn() => this.FirewallArn != null;

        /// <summary>
        /// Gets and sets the property FirewallName. 
        /// <para>
        /// The descriptive name of the firewall. You can't change the name of a firewall after
        /// you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FirewallName { get; set; }

        /// <summary>
        /// Checks to see if the FirewallName property is set.
        /// </summary>
        internal bool IsSetFirewallName() => this.FirewallName != null;

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// An optional token that you can use for optimistic locking. Network Firewall returns
        /// a token to your requests that access the firewall. The token marks the state of the
        /// firewall resource at the time of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make an unconditional change to the firewall, omit the token in your update request.
        /// Without the token, Network Firewall performs your updates regardless of whether the
        /// firewall has changed since you last retrieved it.
        /// </para>
        ///  
        /// <para>
        /// To make a conditional change to the firewall, provide the token in your update request.
        /// Network Firewall uses the token to ensure that the firewall hasn't changed since you
        /// last retrieved it. If it has changed, the operation fails with an <c>InvalidTokenException</c>.
        /// If this happens, retrieve the firewall again to get a current copy of it with a new
        /// token. Reapply your changes as needed, then try the operation again using the new
        /// token. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdateToken property is set.
        /// </summary>
        internal bool IsSetUpdateToken() => this.UpdateToken != null;
    }
}
