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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// Amazon Elastic Inference is no longer available.
    /// </para>
    ///  </note> 
    /// <para>
    /// Describes the Inference accelerators for the instance type.
    /// </para>
    /// </summary>
    public partial class InferenceAcceleratorInfo
    {
        private List<InferenceDeviceInfo> _accelerators = AWSConfigs.InitializeCollections ? new List<InferenceDeviceInfo>() : null;
        private int? _totalInferenceMemoryInMiB;

        /// <summary>
        /// Gets and sets the property Accelerators. 
        /// <para>
        /// Describes the Inference accelerators for the instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InferenceDeviceInfo> Accelerators
        {
            get { return this._accelerators; }
            set { this._accelerators = value; }
        }

        // Check to see if Accelerators property is set
        internal bool IsSetAccelerators()
        {
            return this._accelerators != null && (this._accelerators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalInferenceMemoryInMiB. 
        /// <para>
        /// The total size of the memory for the inference accelerators for the instance type,
        /// in MiB.
        /// </para>
        /// </summary>
        public int? TotalInferenceMemoryInMiB
        {
            get { return this._totalInferenceMemoryInMiB; }
            set { this._totalInferenceMemoryInMiB = value; }
        }

        // Check to see if TotalInferenceMemoryInMiB property is set
        internal bool IsSetTotalInferenceMemoryInMiB()
        {
            return this._totalInferenceMemoryInMiB.HasValue; 
        }

    }
}