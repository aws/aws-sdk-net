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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
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
namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Information about a network site.
    /// </summary>
    public partial class NetworkSite
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private DateTime? _createdAt;
        private SitePlan _currentPlan;
        private string _description;
        private string _networkArn;
        private string _networkSiteArn;
        private string _networkSiteName;
        private SitePlan _pendingPlan;
        private NetworkSiteStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The parent Availability Zone for the network site. 
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        ///  The parent Availability Zone ID for the network site. 
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The creation time of the network site.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentPlan. 
        /// <para>
        /// The current plan of the network site.
        /// </para>
        /// </summary>
        public SitePlan CurrentPlan
        {
            get { return this._currentPlan; }
            set { this._currentPlan = value; }
        }

        // Check to see if CurrentPlan property is set
        internal bool IsSetCurrentPlan()
        {
            return this._currentPlan != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the network site.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Gets and sets the property NetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network to which the network site belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkArn
        {
            get { return this._networkArn; }
            set { this._networkArn = value; }
        }

        // Check to see if NetworkArn property is set
        internal bool IsSetNetworkArn()
        {
            return this._networkArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkSiteArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network site.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkSiteArn
        {
            get { return this._networkSiteArn; }
            set { this._networkSiteArn = value; }
        }

        // Check to see if NetworkSiteArn property is set
        internal bool IsSetNetworkSiteArn()
        {
            return this._networkSiteArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkSiteName. 
        /// <para>
        /// The name of the network site.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string NetworkSiteName
        {
            get { return this._networkSiteName; }
            set { this._networkSiteName = value; }
        }

        // Check to see if NetworkSiteName property is set
        internal bool IsSetNetworkSiteName()
        {
            return this._networkSiteName != null;
        }

        /// <summary>
        /// Gets and sets the property PendingPlan. 
        /// <para>
        /// The pending plan of the network site.
        /// </para>
        /// </summary>
        public SitePlan PendingPlan
        {
            get { return this._pendingPlan; }
            set { this._pendingPlan = value; }
        }

        // Check to see if PendingPlan property is set
        internal bool IsSetPendingPlan()
        {
            return this._pendingPlan != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the network site.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkSiteStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The status reason of the network site.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}