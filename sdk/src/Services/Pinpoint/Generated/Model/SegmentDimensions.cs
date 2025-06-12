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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
        private Dictionary<string, AttributeDimension> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeDimension>() : null;
        private SegmentBehaviors _behavior;
        private SegmentDemographics _demographic;
        private SegmentLocation _location;
        private Dictionary<string, MetricDimension> _metrics = AWSConfigs.InitializeCollections ? new Dictionary<string, MetricDimension>() : null;
        private Dictionary<string, AttributeDimension> _userAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeDimension>() : null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// One or more custom attributes to use as criteria for the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeDimension> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// The behavior-based criteria, such as how recently users have used your app, for the
        /// segment.
        /// </para>
        /// </summary>
        public SegmentBehaviors Behavior
        {
            get { return this._behavior; }
            set { this._behavior = value; }
        }

        // Check to see if Behavior property is set
        internal bool IsSetBehavior()
        {
            return this._behavior != null;
        }

        /// <summary>
        /// Gets and sets the property Demographic. 
        /// <para>
        /// The demographic-based criteria, such as device platform, for the segment.
        /// </para>
        /// </summary>
        public SegmentDemographics Demographic
        {
            get { return this._demographic; }
            set { this._demographic = value; }
        }

        // Check to see if Demographic property is set
        internal bool IsSetDemographic()
        {
            return this._demographic != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location-based criteria, such as region or GPS coordinates, for the segment.
        /// </para>
        /// </summary>
        public SegmentLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// One or more custom metrics to use as criteria for the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MetricDimension> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// One or more custom user attributes to use as criteria for the segment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeDimension> UserAttributes
        {
            get { return this._userAttributes; }
            set { this._userAttributes = value; }
        }

        // Check to see if UserAttributes property is set
        internal bool IsSetUserAttributes()
        {
            return this._userAttributes != null && (this._userAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}