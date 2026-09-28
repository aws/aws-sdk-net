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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// A range of attribute values. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_range_filters.html">Range
    /// Filters</a>.
    /// </summary>
    public partial class TypedAttributeValueRange
    {
        /// <summary>
        /// Gets and sets the property EndMode. 
        /// <para>
        /// The inclusive or exclusive range end.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RangeMode EndMode { get; set; }

        /// <summary>
        /// Checks to see if the EndMode property is set.
        /// </summary>
        internal bool IsSetEndMode() => this.EndMode != null;

        /// <summary>
        /// Gets and sets the property EndValue. 
        /// <para>
        /// The attribute value to terminate the range at.
        /// </para>
        /// </summary>
        public TypedAttributeValue EndValue { get; set; }

        /// <summary>
        /// Checks to see if the EndValue property is set.
        /// </summary>
        internal bool IsSetEndValue() => this.EndValue != null;

        /// <summary>
        /// Gets and sets the property StartMode. 
        /// <para>
        /// The inclusive or exclusive range start.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RangeMode StartMode { get; set; }

        /// <summary>
        /// Checks to see if the StartMode property is set.
        /// </summary>
        internal bool IsSetStartMode() => this.StartMode != null;

        /// <summary>
        /// Gets and sets the property StartValue. 
        /// <para>
        /// The value to start the range at.
        /// </para>
        /// </summary>
        public TypedAttributeValue StartValue { get; set; }

        /// <summary>
        /// Checks to see if the StartValue property is set.
        /// </summary>
        internal bool IsSetStartValue() => this.StartValue != null;
    }
}
