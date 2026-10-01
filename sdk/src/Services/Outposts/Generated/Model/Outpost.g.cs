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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about an Outpost.
    /// </summary>
    public partial class Outpost
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Generation. 
        /// <para>
        /// The Outpost generation. Valid values are <c>GENERATION_1</c> for first-generation
        /// rack deployments and <c>GENERATION_2</c> for second-generation rack deployments.
        /// </para>
        /// </summary>
        public OutpostGeneration Generation { get; set; }

        /// <summary>
        /// Checks to see if the Generation property is set.
        /// </summary>
        internal bool IsSetGeneration() => this.Generation != null;

        /// <summary>
        /// Gets and sets the property LifeCycleStatus.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string LifeCycleStatus { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycleStatus property is set.
        /// </summary>
        internal bool IsSetLifeCycleStatus() => this.LifeCycleStatus != null;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutpostArn.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        ///  The ID of the Outpost. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 180)]
        public string OutpostId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostId property is set.
        /// </summary>
        internal bool IsSetOutpostId() => this.OutpostId != null;

        /// <summary>
        /// Gets and sets the property OwnerId.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property RackScalingType. 
        /// <para>
        /// The rack scaling type. Valid values are <c>SINGLE_RACK</c> for single-rack Outposts
        /// and <c>MULTI_RACK</c> for multi-rack Outposts that can expand across multiple racks.
        /// </para>
        /// </summary>
        public RackScalingType RackScalingType { get; set; }

        /// <summary>
        /// Checks to see if the RackScalingType property is set.
        /// </summary>
        internal bool IsSetRackScalingType() => this.RackScalingType != null;

        /// <summary>
        /// Gets and sets the property SiteArn.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SiteArn { get; set; }

        /// <summary>
        /// Checks to see if the SiteArn property is set.
        /// </summary>
        internal bool IsSetSiteArn() => this.SiteArn != null;

        /// <summary>
        /// Gets and sets the property SiteId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SiteId { get; set; }

        /// <summary>
        /// Checks to see if the SiteId property is set.
        /// </summary>
        internal bool IsSetSiteId() => this.SiteId != null;

        /// <summary>
        /// Gets and sets the property SupportedHardwareType. 
        /// <para>
        ///  The hardware type. 
        /// </para>
        /// </summary>
        public SupportedHardwareType SupportedHardwareType { get; set; }

        /// <summary>
        /// Checks to see if the SupportedHardwareType property is set.
        /// </summary>
        internal bool IsSetSupportedHardwareType() => this.SupportedHardwareType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The Outpost tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
