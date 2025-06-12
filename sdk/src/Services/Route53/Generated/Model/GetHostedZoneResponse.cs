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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
    /// A complex type that contain the response to a <c>GetHostedZone</c> request.
    /// </summary>
    public partial class GetHostedZoneResponse : AmazonWebServiceResponse
    {
        private HostedZone _hostedZone;
        private DelegationSet _delegationSet;
        private List<VPC> _vpCs = AWSConfigs.InitializeCollections ? new List<VPC>() : null;

        /// <summary>
        /// Gets and sets the property HostedZone. 
        /// <para>
        /// A complex type that contains general information about the specified hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HostedZone HostedZone
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
        /// Gets and sets the property DelegationSet. 
        /// <para>
        /// A complex type that lists the Amazon Route 53 name servers for the specified hosted
        /// zone.
        /// </para>
        /// </summary>
        public DelegationSet DelegationSet
        {
            get { return this._delegationSet; }
            set { this._delegationSet = value; }
        }

        // Check to see if DelegationSet property is set
        internal bool IsSetDelegationSet()
        {
            return this._delegationSet != null;
        }

        /// <summary>
        /// Gets and sets the property VPCs. 
        /// <para>
        /// A complex type that contains information about the VPCs that are associated with the
        /// specified hosted zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<VPC> VPCs
        {
            get { return this._vpCs; }
            set { this._vpCs = value; }
        }

        // Check to see if VPCs property is set
        internal bool IsSetVPCs()
        {
            return this._vpCs != null && (this._vpCs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}