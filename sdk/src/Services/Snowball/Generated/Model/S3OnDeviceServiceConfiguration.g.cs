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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Amazon S3 compatible storage on Snow family devices configuration items.
    /// </summary>
    public partial class S3OnDeviceServiceConfiguration
    {
        /// <summary>
        /// Gets and sets the property FaultTolerance. 
        /// <para>
        /// >Fault tolerance level of the cluster. This indicates the number of nodes that can
        /// go down without degrading the performance of the cluster. This additional input helps
        /// when the specified <c>StorageLimit</c> matches more than one Amazon S3 compatible
        /// storage on Snow family devices service configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public int? FaultTolerance { get; set; }

        /// <summary>
        /// Checks to see if the FaultTolerance property is set.
        /// </summary>
        internal bool IsSetFaultTolerance() => this.FaultTolerance.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceSize. 
        /// <para>
        /// Applicable when creating a cluster. Specifies how many nodes are needed for Amazon
        /// S3 compatible storage on Snow family devices. If specified, the other input can be
        /// omitted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 16)]
        public int? ServiceSize { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSize property is set.
        /// </summary>
        internal bool IsSetServiceSize() => this.ServiceSize.HasValue;

        /// <summary>
        /// Gets and sets the property StorageLimit. 
        /// <para>
        /// If the specified storage limit value matches storage limit of one of the defined configurations,
        /// that configuration will be used. If the specified storage limit value does not match
        /// any defined configuration, the request will fail. If more than one configuration has
        /// the same storage limit as specified, the other input need to be provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? StorageLimit { get; set; }

        /// <summary>
        /// Checks to see if the StorageLimit property is set.
        /// </summary>
        internal bool IsSetStorageLimit() => this.StorageLimit.HasValue;

        /// <summary>
        /// Gets and sets the property StorageUnit. 
        /// <para>
        /// Storage unit. Currently the only supported unit is TB.
        /// </para>
        /// </summary>
        public StorageUnit StorageUnit { get; set; }

        /// <summary>
        /// Checks to see if the StorageUnit property is set.
        /// </summary>
        internal bool IsSetStorageUnit() => this.StorageUnit != null;
    }
}
