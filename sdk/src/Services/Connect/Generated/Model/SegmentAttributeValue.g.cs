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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// A value for a segment attribute. This is structured as a map where the key is <c>valueString</c>
    /// and the value is a string.
    /// </summary>
    public partial class SegmentAttributeValue
    {
        /// <summary>
        /// Gets and sets the property ValueArn. 
        /// <para>
        /// The value of a segment attribute that has to be a valid ARN. This is only supported
        /// for system-defined attributes, not for user-defined attributes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ValueArn { get; set; }

        /// <summary>
        /// Checks to see if the ValueArn property is set.
        /// </summary>
        internal bool IsSetValueArn() => this.ValueArn != null;

        /// <summary>
        /// Gets and sets the property ValueInteger. 
        /// <para>
        /// The value of a segment attribute.
        /// </para>
        /// </summary>
        public int? ValueInteger { get; set; }

        /// <summary>
        /// Checks to see if the ValueInteger property is set.
        /// </summary>
        internal bool IsSetValueInteger() => this.ValueInteger.HasValue;

        /// <summary>
        /// Gets and sets the property ValueList. 
        /// <para>
        /// The value of a segment attribute. This is only supported for system-defined attributes,
        /// not for user-defined attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SegmentAttributeValue> ValueList { get; set; } = AWSConfigs.InitializeCollections ? new List<SegmentAttributeValue>() : null;

        /// <summary>
        /// Checks to see if the ValueList property is set.
        /// </summary>
        internal bool IsSetValueList() => this.ValueList != null && (this.ValueList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValueMap. 
        /// <para>
        /// The value of a segment attribute.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, SegmentAttributeValue> ValueMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SegmentAttributeValue>() : null;

        /// <summary>
        /// Checks to see if the ValueMap property is set.
        /// </summary>
        internal bool IsSetValueMap() => this.ValueMap != null && (this.ValueMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValueString. 
        /// <para>
        /// The value of a segment attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ValueString { get; set; }

        /// <summary>
        /// Checks to see if the ValueString property is set.
        /// </summary>
        internal bool IsSetValueString() => this.ValueString != null;
    }
}
