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
    /// This is the response object from the CreateCapacityReservationBySplitting operation.
    /// </summary>
    public partial class CreateCapacityReservationBySplittingResponse : AmazonWebServiceResponse
    {
        private CapacityReservation _destinationCapacityReservation;
        private int? _instanceCount;
        private CapacityReservation _sourceCapacityReservation;

        /// <summary>
        /// Gets and sets the property DestinationCapacityReservation. 
        /// <para>
        ///  Information about the destination Capacity Reservation. 
        /// </para>
        /// </summary>
        public CapacityReservation DestinationCapacityReservation
        {
            get { return this._destinationCapacityReservation; }
            set { this._destinationCapacityReservation = value; }
        }

        // Check to see if DestinationCapacityReservation property is set
        internal bool IsSetDestinationCapacityReservation()
        {
            return this._destinationCapacityReservation != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        ///  The number of instances in the new Capacity Reservation. The number of instances
        /// in the source Capacity Reservation was reduced by this amount. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SourceCapacityReservation. 
        /// <para>
        ///  Information about the source Capacity Reservation. 
        /// </para>
        /// </summary>
        public CapacityReservation SourceCapacityReservation
        {
            get { return this._sourceCapacityReservation; }
            set { this._sourceCapacityReservation = value; }
        }

        // Check to see if SourceCapacityReservation property is set
        internal bool IsSetSourceCapacityReservation()
        {
            return this._sourceCapacityReservation != null;
        }

    }
}