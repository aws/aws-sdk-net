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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Defines criteria to exclude AMIs from lifecycle actions based on the last time they
    /// were used to launch an instance.
    /// </summary>
    public partial class LifecyclePolicyDetailExclusionRulesAmisLastLaunched
    {
        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Defines the unit of time that the lifecycle policy uses to calculate elapsed time
        /// since the last launch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LifecyclePolicyTimeUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The integer number of units for the time period. For example <c>6</c> (months).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 365)]
        public int? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
