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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Configures the resource instances to use while running the Amazon Braket hybrid job
    /// on Amazon Braket.
    /// </summary>
    public partial class InstanceConfig
    {
        private int? _instanceCount;
        private InstanceType _instanceType;
        private int? _volumeSizeInGb;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Configures the number of resource instances to use while running an Amazon Braket
        /// hybrid job on Amazon Braket. The default value is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Configures the type of resource instances to use while running an Amazon Braket hybrid
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceType InstanceType
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
        /// Gets and sets the property VolumeSizeInGb. 
        /// <para>
        /// The size of the storage volume, in GB, to provision.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? VolumeSizeInGb
        {
            get { return this._volumeSizeInGb; }
            set { this._volumeSizeInGb = value; }
        }

        // Check to see if VolumeSizeInGb property is set
        internal bool IsSetVolumeSizeInGb()
        {
            return this._volumeSizeInGb.HasValue; 
        }

    }
}