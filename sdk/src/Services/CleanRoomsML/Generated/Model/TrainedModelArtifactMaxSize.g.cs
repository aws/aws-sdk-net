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
    /// Specifies the maximum size limit for trained model artifacts. This configuration helps
    /// control storage costs and ensures that trained models don't exceed specified size
    /// constraints. The size limit applies to the total size of all artifacts produced by
    /// the training job.
    /// </summary>
    public partial class TrainedModelArtifactMaxSize
    {
        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit of measurement for the maximum artifact size. Valid values include common
        /// storage units such as bytes, kilobytes, megabytes, gigabytes, and terabytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainedModelArtifactMaxSizeUnitType Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The numerical value for the maximum artifact size limit. This value is interpreted
        /// according to the specified unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public double? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
