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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains the number and percentage of findings of a finding type.
    /// </summary>
    public partial class TypeDistribution
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of findings of this type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property DominantSeverity. 
        /// <para>
        /// The most common severity among findings of this type.
        /// </para>
        /// </summary>
        public string DominantSeverity { get; set; }

        /// <summary>
        /// Checks to see if the DominantSeverity property is set.
        /// </summary>
        internal bool IsSetDominantSeverity() => this.DominantSeverity != null;

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// The finding type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string FindingType { get; set; }

        /// <summary>
        /// Checks to see if the FindingType property is set.
        /// </summary>
        internal bool IsSetFindingType() => this.FindingType != null;

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        /// The percentage of findings that are of this type, from 0 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? Percentage { get; set; }

        /// <summary>
        /// Checks to see if the Percentage property is set.
        /// </summary>
        internal bool IsSetPercentage() => this.Percentage.HasValue;
    }
}
