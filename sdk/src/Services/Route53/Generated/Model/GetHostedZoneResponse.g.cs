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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// This is the response object from the GetHostedZone operation.
    /// </summary>
    public partial class GetHostedZoneResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HostedZone. 
        /// <para>
        /// A complex type that contains general information about the specified hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HostedZone HostedZone { get; set; }

        /// <summary>
        /// Checks to see if the HostedZone property is set.
        /// </summary>
        internal bool IsSetHostedZone() => this.HostedZone != null;

        /// <summary>
        /// Gets and sets the property DelegationSet. 
        /// <para>
        /// A complex type that lists the Amazon Route 53 name servers for the specified hosted
        /// zone.
        /// </para>
        /// </summary>
        public DelegationSet DelegationSet { get; set; }

        /// <summary>
        /// Checks to see if the DelegationSet property is set.
        /// </summary>
        internal bool IsSetDelegationSet() => this.DelegationSet != null;

        /// <summary>
        /// Gets and sets the property VPCs. 
        /// <para>
        /// A complex type that contains information about the VPCs that are associated with the
        /// specified hosted zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<VPC> VPCs { get; set; } = AWSConfigs.InitializeCollections ? new List<VPC>() : null;

        /// <summary>
        /// Checks to see if the VPCs property is set.
        /// </summary>
        internal bool IsSetVPCs() => this.VPCs != null && (this.VPCs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
