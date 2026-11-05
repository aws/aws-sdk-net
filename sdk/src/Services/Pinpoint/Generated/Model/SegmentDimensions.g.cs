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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the dimension settings for a segment.
    /// </summary>
    public partial class SegmentDimensions
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more custom attributes to use as criteria for the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeDimension> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeDimension>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// The behavior-based criteria, such as how recently users have used your app, for the
        /// segment.
        /// </para>
        /// </summary>
        public SegmentBehaviors Behavior { get; set; }

        /// <summary>
        /// Checks to see if the Behavior property is set.
        /// </summary>
        internal bool IsSetBehavior() => this.Behavior != null;

        /// <summary>
        /// Gets and sets the property Demographic. 
        /// <para>
        /// The demographic-based criteria, such as device platform, for the segment.
        /// </para>
        /// </summary>
        public SegmentDemographics Demographic { get; set; }

        /// <summary>
        /// Checks to see if the Demographic property is set.
        /// </summary>
        internal bool IsSetDemographic() => this.Demographic != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location-based criteria, such as region or GPS coordinates, for the segment.
        /// </para>
        /// </summary>
        public SegmentLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// One or more custom metrics to use as criteria for the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MetricDimension> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, MetricDimension>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// One or more custom user attributes to use as criteria for the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeDimension> UserAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeDimension>() : null;

        /// <summary>
        /// Checks to see if the UserAttributes property is set.
        /// </summary>
        internal bool IsSetUserAttributes() => this.UserAttributes != null && (this.UserAttributes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
