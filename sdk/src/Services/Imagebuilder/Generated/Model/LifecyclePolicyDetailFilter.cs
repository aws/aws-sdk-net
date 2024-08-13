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
    /// Defines filters that the lifecycle policy uses to determine impacted resource.
    /// </summary>
    public partial class LifecyclePolicyDetailFilter
    {
        private int? _retainAtLeast;
        private LifecyclePolicyDetailFilterType _type;
        private LifecyclePolicyTimeUnit _unit;
        private int? _value;

        /// <summary>
        /// Gets and sets the property RetainAtLeast. 
        /// <para>
        /// For age-based filters, this is the number of resources to keep on hand after the lifecycle
        /// <c>DELETE</c> action is applied. Impacted resources are only deleted if you have more
        /// than this number of resources. If you have fewer resources than this number, the impacted
        /// resource is not deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public int? RetainAtLeast
        {
            get { return this._retainAtLeast; }
            set { this._retainAtLeast = value; }
        }

        // Check to see if RetainAtLeast property is set
        internal bool IsSetRetainAtLeast()
        {
            return this._retainAtLeast.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Filter resources based on either <c>age</c> or <c>count</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LifecyclePolicyDetailFilterType Type
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
        /// Gets and sets the property Unit. 
        /// <para>
        /// Defines the unit of time that the lifecycle policy uses to determine impacted resources.
        /// This is required for age-based rules.
        /// </para>
        /// </summary>
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
        /// The number of units for the time period or for the count. For example, a value of
        /// <c>6</c> might refer to six months or six AMIs.
        /// </para>
        ///  <note> 
        /// <para>
        /// For count-based filters, this value represents the minimum number of resources to
        /// keep on hand. If you have fewer resources than this number, the resource is excluded
        /// from lifecycle actions.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
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