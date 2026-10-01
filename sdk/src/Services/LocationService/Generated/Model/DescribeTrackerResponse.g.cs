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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// This is the response object from the DescribeTracker operation.
    /// </summary>
    public partial class DescribeTrackerResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp for when the tracker resource was created in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for the tracker resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventBridgeEnabled. 
        /// <para>
        /// Whether <c>UPDATE</c> events from this tracker in EventBridge are enabled. If set
        /// to <c>true</c> these events will be sent to EventBridge.
        /// </para>
        /// </summary>
        public bool? EventBridgeEnabled { get; set; }

        /// <summary>
        /// Checks to see if the EventBridgeEnabled property is set.
        /// </summary>
        internal bool IsSetEventBridgeEnabled() => this.EventBridgeEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyEnableGeospatialQueries. 
        /// <para>
        /// Enables <c>GeospatialQueries</c> for a tracker that uses a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keys.html">Amazon
        /// Web Services KMS customer managed key</a>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only used if you are using a KMS customer managed key.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you wish to encrypt your data using your own KMS customer managed key, then the
        /// Bounding Polygon Queries feature will be disabled by default. This is because by using
        /// this feature, a representation of your device positions will not be encrypted using
        /// the your KMS managed key. The exact device position, however; is still encrypted using
        /// your managed key.
        /// </para>
        ///  
        /// <para>
        /// You can choose to opt-in to the Bounding Polygon Quseries feature. This is done by
        /// setting the <c>KmsKeyEnableGeospatialQueries</c> parameter to true when creating or
        /// updating a Tracker.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? KmsKeyEnableGeospatialQueries { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyEnableGeospatialQueries property is set.
        /// </summary>
        internal bool IsSetKmsKeyEnableGeospatialQueries() => this.KmsKeyEnableGeospatialQueries.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// A key identifier for an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keys.html">Amazon
        /// Web Services KMS customer managed key</a> assigned to the Amazon Location resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property PositionFiltering. 
        /// <para>
        /// The position filtering method of the tracker resource.
        /// </para>
        /// </summary>
        public PositionFiltering PositionFiltering { get; set; }

        /// <summary>
        /// Checks to see if the PositionFiltering property is set.
        /// </summary>
        internal bool IsSetPositionFiltering() => this.PositionFiltering != null;

        /// <summary>
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// Always returns <c>RequestBasedUsage</c>.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated. Always returns RequestBasedUsage.")]
        public PricingPlan PricingPlan { get; set; }

        /// <summary>
        /// Checks to see if the PricingPlan property is set.
        /// </summary>
        internal bool IsSetPricingPlan() => this.PricingPlan != null;

        /// <summary>
        /// Gets and sets the property PricingPlanDataSource. 
        /// <para>
        /// No longer used. Always returns an empty string.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated. Unused.")]
        public string PricingPlanDataSource { get; set; }

        /// <summary>
        /// Checks to see if the PricingPlanDataSource property is set.
        /// </summary>
        internal bool IsSetPricingPlanDataSource() => this.PricingPlanDataSource != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the tracker resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrackerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the tracker resource. Used when you need to specify
        /// a resource across all Amazon Web Services.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Format example: <c>arn:aws:geo:region:account-id:tracker/ExampleTracker</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Max = 1600)]
        public string TrackerArn { get; set; }

        /// <summary>
        /// Checks to see if the TrackerArn property is set.
        /// </summary>
        internal bool IsSetTrackerArn() => this.TrackerArn != null;

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the tracker resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TrackerName { get; set; }

        /// <summary>
        /// Checks to see if the TrackerName property is set.
        /// </summary>
        internal bool IsSetTrackerName() => this.TrackerName != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The timestamp for when the tracker resource was last updated in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
