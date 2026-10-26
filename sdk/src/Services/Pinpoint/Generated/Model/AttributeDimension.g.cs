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
    /// Specifies attribute-based criteria for including or excluding endpoints from a segment.
    /// </summary>
    public partial class AttributeDimension
    {
        /// <summary>
        /// Gets and sets the property AttributeType. 
        /// <para>
        /// The type of segment dimension to use. Valid values are: &lt;ul&gt;<li>INCLUSIVE -
        /// endpoints that have attributes matching the values are included in the segment.</li><li>EXCLUSIVE
        /// - endpoints that have attributes matching the values are excluded in the segment.</li><li>CONTAINS
        /// - endpoints that have attributes' substrings match the values are included in the
        /// segment.</li><li>BEFORE - endpoints with attributes read as ISO_INSTANT datetimes
        /// before the value are included in the segment.</li><li>AFTER - endpoints with attributes
        /// read as ISO_INSTANT datetimes after the value are included in the segment.</li><li>ON
        /// - endpoints with attributes read as ISO_INSTANT dates on the value are included in
        /// the segment. Time is ignored in this comparison.</li><li>BETWEEN - endpoints with
        /// attributes read as ISO_INSTANT datetimes between the values are included in the segment.</li>
        /// </para>
        /// </summary>
        public AttributeType AttributeType { get; set; }

        /// <summary>
        /// Checks to see if the AttributeType property is set.
        /// </summary>
        internal bool IsSetAttributeType() => this.AttributeType != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The criteria values to use for the segment dimension. Depending on the value of the
        /// AttributeType property, endpoints are included or excluded from the segment if their
        /// attribute values match the criteria values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
