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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies an instance type and its priority for a heterogeneous endpoint. Use instance
    /// pools to configure a production variant with multiple instance types, enabling the
    /// endpoint to provision instances across different types based on priority.
    /// </summary>
    public partial class InstancePool
    {
        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type for the instance pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProductionVariantInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property ModelNameOverride. 
        /// <para>
        /// The name of a SageMaker model to use for this instance pool instead of the model specified
        /// for the production variant. Use this to deploy a different model optimized for the
        /// instance type in this pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string ModelNameOverride { get; set; }

        /// <summary>
        /// Checks to see if the ModelNameOverride property is set.
        /// </summary>
        internal bool IsSetModelNameOverride() => this.ModelNameOverride != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority for the instance pool. SageMaker attempts to provision instances in order
        /// of priority, starting with the lowest value. If instances for a higher-priority pool
        /// are unavailable, SageMaker attempts to provision from the next pool.
        /// </para>
        ///  
        /// <para>
        /// Valid values: 1 to 5, where 1 is the highest priority.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;
    }
}
