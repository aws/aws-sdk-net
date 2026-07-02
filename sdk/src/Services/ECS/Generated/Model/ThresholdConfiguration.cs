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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Defines the failure threshold that the deployment circuit breaker uses to monitor
    /// a deployment. The <c>type</c> and <c>value</c> together determine the number of task
    /// failures that are tolerated before the circuit breaker triggers.
    /// 
    ///  
    /// <para>
    /// By default, the threshold configuration uses a <c>type</c> of <c>BOUNDED_PERCENT</c>
    /// with a <c>value</c> of <c>50</c>.
    /// </para>
    /// </summary>
    public partial class ThresholdConfiguration
    {
        private ThresholdType _type;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Determines how <c>value</c> is used to calculate the failure threshold. For the percentage
        /// types (<c>BOUNDED_PERCENT</c> and <c>UNBOUNDED_PERCENT</c>), <c>value</c> is multiplied
        /// by the latest service desired count; for <c>COUNT</c>, <c>value</c> is used directly.
        /// The default is <c>BOUNDED_PERCENT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ThresholdType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The integer used to calculate the failure threshold. When <c>type</c> is <c>COUNT</c>,
        /// this is the failure threshold itself. When <c>type</c> is a percentage type, this
        /// is the percentage that Amazon ECS multiplies by the latest service desired count to
        /// calculate the failure threshold.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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