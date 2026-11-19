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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains information about how and when instances in an interruptible reservation
    /// can be terminated when capacity is reclaimed.
    /// </summary>
    public partial class InterruptionInfo
    {
        /// <summary>
        /// Gets and sets the property InterruptionType. 
        /// <para>
        ///  The interruption type that determines how instances are terminated when capacity
        /// is reclaimed. 
        /// </para>
        /// </summary>
        public InterruptionType InterruptionType { get; set; }

        /// <summary>
        /// Checks to see if the InterruptionType property is set.
        /// </summary>
        internal bool IsSetInterruptionType() => this.InterruptionType != null;

        /// <summary>
        /// Gets and sets the property SourceCapacityReservationId. 
        /// <para>
        ///  The ID of the source Capacity Reservation from which the interruptible reservation
        /// was created. 
        /// </para>
        /// </summary>
        public string SourceCapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the SourceCapacityReservationId property is set.
        /// </summary>
        internal bool IsSetSourceCapacityReservationId() => this.SourceCapacityReservationId != null;
    }
}
