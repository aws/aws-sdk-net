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
    /// Instance details for a recommendation.
    /// </summary>
    public partial class AIRecommendationInstanceDetail
    {
        private int? _copyCountPerInstance;
        private int? _instanceCount;
        private AIRecommendationInstanceType _instanceType;

        /// <summary>
        /// Gets and sets the property CopyCountPerInstance. 
        /// <para>
        /// The number of model copies per instance.
        /// </para>
        /// </summary>
        public int? CopyCountPerInstance
        {
            get { return this._copyCountPerInstance; }
            set { this._copyCountPerInstance = value; }
        }

        // Check to see if CopyCountPerInstance property is set
        internal bool IsSetCopyCountPerInstance()
        {
            return this._copyCountPerInstance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The recommended number of instances.
        /// </para>
        /// </summary>
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The recommended instance type.
        /// </para>
        /// </summary>
        public AIRecommendationInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

    }
}