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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies the type and size of the endpoint capacity to activate for a blue/green
    /// deployment, a rolling deployment, or a rollback strategy. You can specify your batches
    /// as either instance count or the overall percentage or your fleet.
    /// 
    ///  
    /// <para>
    /// For a rollback strategy, if you don't specify the fields in this object, or if you
    /// set the <c>Value</c> to 100%, then SageMaker uses a blue/green rollback strategy and
    /// rolls all traffic back to the blue fleet.
    /// </para>
    /// </summary>
    public partial class CapacitySize
    {
        private CapacitySizeType _type;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the endpoint capacity type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INSTANCE_COUNT</c>: The endpoint activates based on the number of instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CAPACITY_PERCENT</c>: The endpoint activates based on the specified percentage
        /// of capacity.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacitySizeType Type
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
        /// Defines the capacity size, either as a number of instances or a capacity percentage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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