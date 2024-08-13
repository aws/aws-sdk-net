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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// The configuration of the resource used to execute the <c>containerAction</c>.
    /// </summary>
    public partial class ResourceConfiguration
    {
        private ComputeType _computeType;
        private int? _volumeSizeInGB;

        /// <summary>
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// The type of the compute resource used to execute the <c>containerAction</c>. Possible
        /// values are: <c>ACU_1</c> (vCPU=4, memory=16 GiB) or <c>ACU_2</c> (vCPU=8, memory=32
        /// GiB).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeType ComputeType
        {
            get { return this._computeType; }
            set { this._computeType = value; }
        }

        // Check to see if ComputeType property is set
        internal bool IsSetComputeType()
        {
            return this._computeType != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The size, in GB, of the persistent storage available to the resource instance used
        /// to execute the <c>containerAction</c> (min: 1, max: 50).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public int? VolumeSizeInGB
        {
            get { return this._volumeSizeInGB; }
            set { this._volumeSizeInGB = value; }
        }

        // Check to see if VolumeSizeInGB property is set
        internal bool IsSetVolumeSizeInGB()
        {
            return this._volumeSizeInGB.HasValue; 
        }

    }
}