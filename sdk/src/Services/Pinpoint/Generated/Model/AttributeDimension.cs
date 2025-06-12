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
    /// Specifies attribute-based criteria for including or excluding endpoints from a segment.
    /// </summary>
    public partial class AttributeDimension
    {
        private AttributeType _attributeType;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AttributeType. 
        /// <para>
        /// The type of segment dimension to use. Valid values are: <ul><li>INCLUSIVE - endpoints
        /// that have attributes matching the values are included in the segment.</li><li>EXCLUSIVE
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
        public AttributeType AttributeType
        {
            get { return this._attributeType; }
            set { this._attributeType = value; }
        }

        // Check to see if AttributeType property is set
        internal bool IsSetAttributeType()
        {
            return this._attributeType != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The criteria values to use for the segment dimension. Depending on the value of the
        /// AttributeType property, endpoints are included or excluded from the segment if their
        /// attribute values match the criteria values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}