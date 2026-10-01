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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about a specified Amazon Route 53 hosted zone, including the four
    /// name servers assigned to the hosted zone. A hosted zone represents a collection of
    /// records that can be managed together, belonging to a single parent domain name.
    /// </summary>
    public partial class AwsRoute53HostedZoneDetails
    {
        /// <summary>
        /// Gets and sets the property HostedZone. 
        /// <para>
        ///  An object that contains information about the specified hosted zone.
        /// </para>
        /// </summary>
        public AwsRoute53HostedZoneObjectDetails HostedZone { get; set; }

        /// <summary>
        /// Checks to see if the HostedZone property is set.
        /// </summary>
        internal bool IsSetHostedZone() => this.HostedZone != null;

        /// <summary>
        /// Gets and sets the property NameServers. 
        /// <para>
        ///  An object that contains a list of the authoritative name servers for a hosted zone
        /// or for a reusable delegation set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NameServers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NameServers property is set.
        /// </summary>
        internal bool IsSetNameServers() => this.NameServers != null && (this.NameServers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryLoggingConfig. 
        /// <para>
        ///  An array that contains one <c>QueryLoggingConfig</c> element for each DNS query logging
        /// configuration that is associated with the current Amazon Web Services account.
        /// </para>
        /// </summary>
        public AwsRoute53QueryLoggingConfigDetails QueryLoggingConfig { get; set; }

        /// <summary>
        /// Checks to see if the QueryLoggingConfig property is set.
        /// </summary>
        internal bool IsSetQueryLoggingConfig() => this.QueryLoggingConfig != null;

        /// <summary>
        /// Gets and sets the property Vpcs. 
        /// <para>
        ///  An object that contains information about the Amazon Virtual Private Clouds (Amazon
        /// VPCs) that are associated with the specified hosted zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRoute53HostedZoneVpcDetails> Vpcs { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRoute53HostedZoneVpcDetails>() : null;

        /// <summary>
        /// Checks to see if the Vpcs property is set.
        /// </summary>
        internal bool IsSetVpcs() => this.Vpcs != null && (this.Vpcs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
