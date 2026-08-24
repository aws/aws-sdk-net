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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains information about a routing policy registration that represents a Route Origin
    /// Authorization (ROA) managed through IPAM.
    /// </summary>
    public partial class IpamRoutingPolicyRegistration
    {
        private List<string> _asns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _cidr;
        private string _description;
        private string _latestDeltaId;
        private int? _maxLength;
        private bool? _permitMoreSpecificAnnouncements;
        private IpamRoutingPolicyRegistrationState _state;

        /// <summary>
        /// Gets and sets the property Asns. 
        /// <para>
        /// The Autonomous System Numbers (ASNs) authorized to originate the prefix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Asns
        {
            get { return this._asns; }
            set { this._asns = value; }
        }

        // Check to see if Asns property is set
        internal bool IsSetAsns()
        {
            return this._asns != null && (this._asns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IP address prefix in CIDR notation authorized by the ROA.
        /// </para>
        /// </summary>
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the routing policy registration.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LatestDeltaId. 
        /// <para>
        /// The ID of the most recent delta that modified this registration.
        /// </para>
        /// </summary>
        public string LatestDeltaId
        {
            get { return this._latestDeltaId; }
            set { this._latestDeltaId = value; }
        }

        // Check to see if LatestDeltaId property is set
        internal bool IsSetLatestDeltaId()
        {
            return this._latestDeltaId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum prefix length that the ASNs are authorized to announce.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=48)]
        public int? MaxLength
        {
            get { return this._maxLength; }
            set { this._maxLength = value; }
        }

        // Check to see if MaxLength property is set
        internal bool IsSetMaxLength()
        {
            return this._maxLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PermitMoreSpecificAnnouncements. 
        /// <para>
        /// Specifies whether to permit more specific route announcements than the CIDR prefix.
        /// When enabled, ASNs can announce sub-prefixes of the authorized CIDR up to the specified
        /// maximum length. Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? PermitMoreSpecificAnnouncements
        {
            get { return this._permitMoreSpecificAnnouncements; }
            set { this._permitMoreSpecificAnnouncements = value; }
        }

        // Check to see if PermitMoreSpecificAnnouncements property is set
        internal bool IsSetPermitMoreSpecificAnnouncements()
        {
            return this._permitMoreSpecificAnnouncements.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the routing policy registration. Valid values: <c>pending-activate</c>
        /// | <c>activate-failed</c> | <c>create-in-progress</c> | <c>create-complete</c> | <c>update-in-progress</c>
        /// | <c>update-complete</c> | <c>delete-in-progress</c> | <c>delete-complete</c>.
        /// </para>
        /// </summary>
        public IpamRoutingPolicyRegistrationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}