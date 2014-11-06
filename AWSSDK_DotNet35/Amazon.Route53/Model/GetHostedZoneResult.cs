/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type containing information about the specified hosted zone.
    /// </summary>
    public partial class GetHostedZoneResult : AmazonWebServiceResponse
    {
        private HostedZone _hostedZone;
        private DelegationSet _delegationSet;
        private List<VPC> _vPCs = new List<VPC>();

        /// <summary>
        /// Gets and sets the property HostedZone. 
        /// <para>
        /// A complex type that contains the information about the specified hosted zone.
        /// </para>
        /// </summary>
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
        /// A complex type that contains information about the name servers for the specified
        /// hosted zone.
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
        /// A complex type that contains information about VPCs associated with the specified
        /// hosted zone.
        /// </para>
        /// </summary>
        public List<VPC> VPCs
        {
            get { return this._vPCs; }
            set { this._vPCs = value; }
        }

        // Check to see if VPCs property is set
        internal bool IsSetVPCs()
        {
            return this._vPCs != null && this._vPCs.Count > 0; 
        }

    }
}