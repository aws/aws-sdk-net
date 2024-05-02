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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
        private LifecyclePolicyTimeUnit _unit;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Defines the unit of time that the lifecycle policy uses to calculate elapsed time
        /// since the last instance launched from the AMI. For example: days, weeks, months, or
        /// years.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LifecyclePolicyTimeUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The integer number of units for the time period. For example <c>6</c> (months).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=365)]
        public int? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}