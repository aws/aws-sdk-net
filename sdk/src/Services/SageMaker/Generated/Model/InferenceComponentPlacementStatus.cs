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
    /// The placement status of an inference component on a specific instance type. Shows
    /// the number of inference component copies currently placed on instances of a given
    /// type.
    /// </summary>
    public partial class InferenceComponentPlacementStatus
    {
        private int? _currentCopyCount;
        private ProductionVariantInstanceType _instanceType;

        /// <summary>
        /// Gets and sets the property CurrentCopyCount. 
        /// <para>
        /// The number of inference component copies currently placed on instances of this type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? CurrentCopyCount
        {
            get { return this._currentCopyCount; }
            set { this._currentCopyCount = value; }
        }

        // Check to see if CurrentCopyCount property is set
        internal bool IsSetCurrentCopyCount()
        {
            return this._currentCopyCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The ML compute instance type where the inference component copies are placed.
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

    }
}