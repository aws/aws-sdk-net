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
    /// The conditions including range, object count, and threshold for the calculated attribute.
    /// </summary>
    public partial class Conditions
    {
        /// <summary>
        /// Gets and sets the property ObjectCount. 
        /// <para>
        /// The number of profile objects used for the calculated attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? ObjectCount { get; set; }

        /// <summary>
        /// Checks to see if the ObjectCount property is set.
        /// </summary>
        internal bool IsSetObjectCount() => this.ObjectCount.HasValue;

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// The relative time period over which data is included in the aggregation.
        /// </para>
        /// </summary>
        public Range Range { get; set; }

        /// <summary>
        /// Checks to see if the Range property is set.
        /// </summary>
        internal bool IsSetRange() => this.Range != null;

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The threshold for the calculated attribute.
        /// </para>
        /// </summary>
        public Threshold Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold != null;
    }
}
