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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
    /// Provides details about a specified Amazon Route 53 hosted zone, including the four
    /// name servers assigned to the hosted zone. A hosted zone represents a collection of
    /// records that can be managed together, belonging to a single parent domain name.
    /// </summary>
    public partial class AwsRoute53HostedZoneDetails
    {
        private AwsRoute53HostedZoneObjectDetails _hostedZone;
        private List<string> _nameServers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AwsRoute53QueryLoggingConfigDetails _queryLoggingConfig;
        private List<AwsRoute53HostedZoneVpcDetails> _vpcs = AWSConfigs.InitializeCollections ? new List<AwsRoute53HostedZoneVpcDetails>() : null;

        /// <summary>
        /// Gets and sets the property HostedZone. 
        /// <para>
        ///  An object that contains information about the specified hosted zone.
        /// </para>
        /// </summary>
        public AwsRoute53HostedZoneObjectDetails HostedZone
        {
            get { return this._hostedZone; }
            set { this._hostedZone = value; }
        }

        // Check to see if HostedZone property is set
        internal bool IsSetHostedZone()
        {
            return this._hostedZone != null;
        }

        /// <summary>
        /// Gets and sets the property NameServers. 
        /// <para>
        ///  An object that contains a list of the authoritative name servers for a hosted zone
        /// or for a reusable delegation set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NameServers
        {
            get { return this._nameServers; }
            set { this._nameServers = value; }
        }

        // Check to see if NameServers property is set
        internal bool IsSetNameServers()
        {
            return this._nameServers != null && (this._nameServers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryLoggingConfig. 
        /// <para>
        ///  An array that contains one <c>QueryLoggingConfig</c> element for each DNS query logging
        /// configuration that is associated with the current Amazon Web Services account.
        /// </para>
        /// </summary>
        public AwsRoute53QueryLoggingConfigDetails QueryLoggingConfig
        {
            get { return this._queryLoggingConfig; }
            set { this._queryLoggingConfig = value; }
        }

        // Check to see if QueryLoggingConfig property is set
        internal bool IsSetQueryLoggingConfig()
        {
            return this._queryLoggingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Vpcs. 
        /// <para>
        ///  An object that contains information about the Amazon Virtual Private Clouds (Amazon
        /// VPCs) that are associated with the specified hosted zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRoute53HostedZoneVpcDetails> Vpcs
        {
            get { return this._vpcs; }
            set { this._vpcs = value; }
        }

        // Check to see if Vpcs property is set
        internal bool IsSetVpcs()
        {
            return this._vpcs != null && (this._vpcs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}