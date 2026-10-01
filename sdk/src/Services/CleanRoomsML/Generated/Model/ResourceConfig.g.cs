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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Information about the EC2 resources that are used to train the model.
    /// </summary>
    public partial class ResourceConfig
    {
        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of resources that are used to train the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type that is used to train the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property VolumeSizeInGB. 
        /// <para>
        /// The volume size of the instance that is used to train the model. Please see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-store-volumes.html">EC2
        /// volume limit</a> for volume size limitations on different instance types.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public int? VolumeSizeInGB { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSizeInGB property is set.
        /// </summary>
        internal bool IsSetVolumeSizeInGB() => this.VolumeSizeInGB.HasValue;
    }
}
