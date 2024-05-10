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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the GPU accelerator settings for the instance type.
    /// </summary>
    public partial class GpuInfo
    {
        private List<Gpu> _gpus = AWSConfigs.InitializeCollections ? new List<Gpu>() : null;

        /// <summary>
        /// Gets and sets the property Gpus. 
        /// <para>
        ///  Describes the GPU accelerators for the instance type. 
        /// </para>
        /// </summary>
        public List<Gpu> Gpus
        {
            get { return this._gpus; }
            set { this._gpus = value; }
        }

        // Check to see if Gpus property is set
        internal bool IsSetGpus()
        {
            return this._gpus != null && (this._gpus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}