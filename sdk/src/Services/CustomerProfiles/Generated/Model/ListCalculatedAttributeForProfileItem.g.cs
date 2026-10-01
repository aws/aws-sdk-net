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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The details of a single calculated attribute for a profile.
    /// </summary>
    public partial class ListCalculatedAttributeForProfileItem
    {
        /// <summary>
        /// Gets and sets the property CalculatedAttributeName. 
        /// <para>
        /// The unique name of the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CalculatedAttributeName { get; set; }

        /// <summary>
        /// Checks to see if the CalculatedAttributeName property is set.
        /// </summary>
        internal bool IsSetCalculatedAttributeName() => this.CalculatedAttributeName != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property IsDataPartial. 
        /// <para>
        /// Indicates whether the calculated attribute’s value is based on partial data. If data
        /// is partial, it is set to true.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string IsDataPartial { get; set; }

        /// <summary>
        /// Checks to see if the IsDataPartial property is set.
        /// </summary>
        internal bool IsSetIsDataPartial() => this.IsDataPartial != null;

        /// <summary>
        /// Gets and sets the property LastObjectTimestamp. 
        /// <para>
        /// The timestamp of the newest object included in the calculated attribute calculation.
        /// </para>
        /// </summary>
        public DateTime? LastObjectTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastObjectTimestamp property is set.
        /// </summary>
        internal bool IsSetLastObjectTimestamp() => this.LastObjectTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
