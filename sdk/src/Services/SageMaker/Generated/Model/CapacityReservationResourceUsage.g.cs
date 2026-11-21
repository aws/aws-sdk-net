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
    /// The instances from a SageMaker Capacity Reservation that one resource type uses in
    /// an account.
    /// </summary>
    public partial class CapacityReservationResourceUsage
    {
        /// <summary>
        /// Gets and sets the property InUseInstanceCount. 
        /// <para>
        /// The number of instances from the SageMaker Capacity Reservation that are in use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? InUseInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InUseInstanceCount property is set.
        /// </summary>
        internal bool IsSetInUseInstanceCount() => this.InUseInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource that uses the instances. Valid values:
        /// </para>
        ///  <dl> <dt>HyperPodClusters</dt> <dd> 
        /// <para>
        /// SageMaker AI HyperPod clusters.
        /// </para>
        ///  </dd> <dt>Endpoints</dt> <dd> 
        /// <para>
        /// SageMaker AI endpoints.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityReservationResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
