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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The definition for a <c>TopicConstantValue</c>.
    /// </summary>
    public partial class TopicConstantValue
    {
        /// <summary>
        /// Gets and sets the property ConstantType. 
        /// <para>
        /// The constant type of a <c>TopicConstantValue</c>.
        /// </para>
        /// </summary>
        public ConstantType ConstantType { get; set; }

        /// <summary>
        /// Checks to see if the ConstantType property is set.
        /// </summary>
        internal bool IsSetConstantType() => this.ConstantType != null;

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        /// The maximum for the <c>TopicConstantValue</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Maximum { get; set; }

        /// <summary>
        /// Checks to see if the Maximum property is set.
        /// </summary>
        internal bool IsSetMaximum() => this.Maximum != null;

        /// <summary>
        /// Gets and sets the property Minimum. 
        /// <para>
        /// The minimum for the <c>TopicConstantValue</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Minimum { get; set; }

        /// <summary>
        /// Checks to see if the Minimum property is set.
        /// </summary>
        internal bool IsSetMinimum() => this.Minimum != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the <c>TopicConstantValue</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;

        /// <summary>
        /// Gets and sets the property ValueList. 
        /// <para>
        /// The value list of the <c>TopicConstantValue</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<CollectiveConstantEntry> ValueList { get; set; } = AWSConfigs.InitializeCollections ? new List<CollectiveConstantEntry>() : null;

        /// <summary>
        /// Checks to see if the ValueList property is set.
        /// </summary>
        internal bool IsSetValueList() => this.ValueList != null && (this.ValueList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
