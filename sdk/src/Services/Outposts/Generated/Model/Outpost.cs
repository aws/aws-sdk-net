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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about an Outpost.
    /// </summary>
    public partial class Outpost
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _description;
        private string _lifeCycleStatus;
        private string _name;
        private string _outpostArn;
        private string _outpostId;
        private string _ownerId;
        private string _siteArn;
        private string _siteId;
        private SupportedHardwareType _supportedHardwareType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property LifeCycleStatus.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string LifeCycleStatus
        {
            get { return this._lifeCycleStatus; }
            set { this._lifeCycleStatus = value; }
        }

        // Check to see if LifeCycleStatus property is set
        internal bool IsSetLifeCycleStatus()
        {
            return this._lifeCycleStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        ///  The ID of the Outpost. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=180)]
        public string OutpostId
        {
            get { return this._outpostId; }
            set { this._outpostId = value; }
        }

        // Check to see if OutpostId property is set
        internal bool IsSetOutpostId()
        {
            return this._outpostId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId.
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property SiteArn.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SiteArn
        {
            get { return this._siteArn; }
            set { this._siteArn = value; }
        }

        // Check to see if SiteArn property is set
        internal bool IsSetSiteArn()
        {
            return this._siteArn != null;
        }

        /// <summary>
        /// Gets and sets the property SiteId.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SiteId
        {
            get { return this._siteId; }
            set { this._siteId = value; }
        }

        // Check to see if SiteId property is set
        internal bool IsSetSiteId()
        {
            return this._siteId != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedHardwareType. 
        /// <para>
        ///  The hardware type. 
        /// </para>
        /// </summary>
        public SupportedHardwareType SupportedHardwareType
        {
            get { return this._supportedHardwareType; }
            set { this._supportedHardwareType = value; }
        }

        // Check to see if SupportedHardwareType property is set
        internal bool IsSetSupportedHardwareType()
        {
            return this._supportedHardwareType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The Outpost tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}