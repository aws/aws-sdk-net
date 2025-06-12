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
    /// This is the response object from the CancelCapacityReservationFleets operation.
    /// </summary>
    public partial class CancelCapacityReservationFleetsResponse : AmazonWebServiceResponse
    {
        private List<FailedCapacityReservationFleetCancellationResult> _failedFleetCancellations = AWSConfigs.InitializeCollections ? new List<FailedCapacityReservationFleetCancellationResult>() : null;
        private List<CapacityReservationFleetCancellationState> _successfulFleetCancellations = AWSConfigs.InitializeCollections ? new List<CapacityReservationFleetCancellationState>() : null;

        /// <summary>
        /// Gets and sets the property FailedFleetCancellations. 
        /// <para>
        /// Information about the Capacity Reservation Fleets that could not be cancelled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedCapacityReservationFleetCancellationResult> FailedFleetCancellations
        {
            get { return this._failedFleetCancellations; }
            set { this._failedFleetCancellations = value; }
        }

        // Check to see if FailedFleetCancellations property is set
        internal bool IsSetFailedFleetCancellations()
        {
            return this._failedFleetCancellations != null && (this._failedFleetCancellations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulFleetCancellations. 
        /// <para>
        /// Information about the Capacity Reservation Fleets that were successfully cancelled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityReservationFleetCancellationState> SuccessfulFleetCancellations
        {
            get { return this._successfulFleetCancellations; }
            set { this._successfulFleetCancellations = value; }
        }

        // Check to see if SuccessfulFleetCancellations property is set
        internal bool IsSetSuccessfulFleetCancellations()
        {
            return this._successfulFleetCancellations != null && (this._successfulFleetCancellations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}