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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Assigns Athena workgroups (and hence their queries) to capacity reservations. A capacity
    /// reservation can have only one capacity assignment configuration, but the capacity
    /// assignment configuration can be made up of multiple individual assignments. Each assignment
    /// specifies how Athena queries can consume capacity from the capacity reservation that
    /// their workgroup is mapped to.
    /// </summary>
    public partial class CapacityAssignmentConfiguration
    {
        /// <summary>
        /// Gets and sets the property CapacityAssignments. 
        /// <para>
        /// The list of assignments that make up the capacity assignment configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityAssignment> CapacityAssignments { get; set; } = AWSConfigs.InitializeCollections ? new List<CapacityAssignment>() : null;

        /// <summary>
        /// Checks to see if the CapacityAssignments property is set.
        /// </summary>
        internal bool IsSetCapacityAssignments() => this.CapacityAssignments != null && (this.CapacityAssignments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityReservationName. 
        /// <para>
        /// The name of the reservation that the capacity assignment configuration is for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string CapacityReservationName { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationName property is set.
        /// </summary>
        internal bool IsSetCapacityReservationName() => this.CapacityReservationName != null;
    }
}
