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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Spot Fleet request.
    /// </summary>
    public partial class SpotFleetRequestConfig
    {
        /// <summary>
        /// Gets and sets the property ActivityStatus. 
        /// <para>
        /// The progress of the Spot Fleet request. If there is an error, the status is <c>error</c>.
        /// After all requests are placed, the status is <c>pending_fulfillment</c>. If the size
        /// of the fleet is equal to or greater than its target capacity, the status is <c>fulfilled</c>.
        /// If the size of the fleet is decreased, the status is <c>pending_termination</c> while
        /// Spot Instances are terminating.
        /// </para>
        /// </summary>
        public ActivityStatus ActivityStatus { get; set; }

        /// <summary>
        /// Checks to see if the ActivityStatus property is set.
        /// </summary>
        internal bool IsSetActivityStatus() => this.ActivityStatus != null;

        /// <summary>
        /// Gets and sets the property ConfigData. 
        /// <para>
        /// The configuration of the Spot Fleet request.
        /// </para>
        /// </summary>
        public SpotFleetRequestConfigData ConfigData { get; set; }

        /// <summary>
        /// Checks to see if the ConfigData property is set.
        /// </summary>
        internal bool IsSetConfigData() => this.ConfigData != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The creation date and time of the request.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property SpotFleetRequestId. 
        /// <para>
        /// The ID of the Spot Fleet request.
        /// </para>
        /// </summary>
        public string SpotFleetRequestId { get; set; }

        /// <summary>
        /// Checks to see if the SpotFleetRequestId property is set.
        /// </summary>
        internal bool IsSetSpotFleetRequestId() => this.SpotFleetRequestId != null;

        /// <summary>
        /// Gets and sets the property SpotFleetRequestState. 
        /// <para>
        /// The state of the Spot Fleet request.
        /// </para>
        /// </summary>
        public BatchState SpotFleetRequestState { get; set; }

        /// <summary>
        /// Checks to see if the SpotFleetRequestState property is set.
        /// </summary>
        internal bool IsSetSpotFleetRequestState() => this.SpotFleetRequestState != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for a Spot Fleet resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
