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
    /// Specifies an instance type and its priority for a heterogeneous endpoint. Use instance
    /// pools to configure a production variant with multiple instance types, enabling the
    /// endpoint to provision instances across different types based on priority.
    /// </summary>
    public partial class InstancePool
    {
        private ProductionVariantInstanceType _instanceType;
        private string _modelNameOverride;
        private int? _priority;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type for the instance pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProductionVariantInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property ModelNameOverride. 
        /// <para>
        /// The name of a SageMaker model to use for this instance pool instead of the model specified
        /// for the production variant. Use this to deploy a different model optimized for the
        /// instance type in this pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string ModelNameOverride
        {
            get { return this._modelNameOverride; }
            set { this._modelNameOverride = value; }
        }

        // Check to see if ModelNameOverride property is set
        internal bool IsSetModelNameOverride()
        {
            return this._modelNameOverride != null;
        }

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
        [AWSProperty(Required=true, Min=1, Max=5)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

    }
}