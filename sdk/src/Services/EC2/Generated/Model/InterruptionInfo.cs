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
    /// Contains information about how and when instances in an interruptible reservation
    /// can be terminated when capacity is reclaimed.
    /// </summary>
    public partial class InterruptionInfo
    {
        private InterruptionType _interruptionType;
        private string _sourceCapacityReservationId;

        /// <summary>
        /// Gets and sets the property InterruptionType. 
        /// <para>
        ///  The interruption type that determines how instances are terminated when capacity
        /// is reclaimed. 
        /// </para>
        /// </summary>
        public InterruptionType InterruptionType
        {
            get { return this._interruptionType; }
            set { this._interruptionType = value; }
        }

        // Check to see if InterruptionType property is set
        internal bool IsSetInterruptionType()
        {
            return this._interruptionType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCapacityReservationId. 
        /// <para>
        ///  The ID of the source Capacity Reservation from which the interruptible reservation
        /// was created. 
        /// </para>
        /// </summary>
        public string SourceCapacityReservationId
        {
            get { return this._sourceCapacityReservationId; }
            set { this._sourceCapacityReservationId = value; }
        }

        // Check to see if SourceCapacityReservationId property is set
        internal bool IsSetSourceCapacityReservationId()
        {
            return this._sourceCapacityReservationId != null;
        }

    }
}