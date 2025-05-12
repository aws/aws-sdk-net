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
    /// The configuration of the size measurements of the AMI update. Using this configuration,
    /// you can specify whether SageMaker should update your instance group by an amount or
    /// percentage of instances.
    /// </summary>
    public partial class CapacitySizeConfig
    {
        private NodeUnavailabilityType _type;
        private int? _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies whether SageMaker should process the update by amount or percentage of instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NodeUnavailabilityType Type
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
        /// Specifies the amount or percentage of instances SageMaker updates at a time.
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