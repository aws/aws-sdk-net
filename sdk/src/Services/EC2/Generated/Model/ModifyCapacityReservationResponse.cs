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
    /// This is the response object from the ModifyCapacityReservation operation.
    /// </summary>
    public partial class ModifyCapacityReservationResponse : AmazonWebServiceResponse
    {
        private CapacityReservationAdjustmentDetails _adjustmentDetails;
        private CapacityReservationAdjustmentStatus _adjustmentStatus;
        private bool? _return;

        /// <summary>
        /// Gets and sets the property AdjustmentDetails. 
        /// <para>
        /// The configuration that the Capacity Reservation will have after the adjustment is
        /// applied.
        /// </para>
        /// </summary>
        public CapacityReservationAdjustmentDetails AdjustmentDetails
        {
            get { return this._adjustmentDetails; }
            set { this._adjustmentDetails = value; }
        }

        // Check to see if AdjustmentDetails property is set
        internal bool IsSetAdjustmentDetails()
        {
            return this._adjustmentDetails != null;
        }

        /// <summary>
        /// Gets and sets the property AdjustmentStatus. 
        /// <para>
        /// The status of the requested modification. For a description of each possible value,
        /// see the <c>adjustmentStatus</c> field of the <c>CapacityReservation</c> data type.
        /// </para>
        /// </summary>
        public CapacityReservationAdjustmentStatus AdjustmentStatus
        {
            get { return this._adjustmentStatus; }
            set { this._adjustmentStatus = value; }
        }

        // Check to see if AdjustmentStatus property is set
        internal bool IsSetAdjustmentStatus()
        {
            return this._adjustmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Return. 
        /// <para>
        /// Returns <c>true</c> if the request succeeds; otherwise, it returns an error.
        /// </para>
        /// </summary>
        public bool? Return
        {
            get { return this._return; }
            set { this._return = value; }
        }

        // Check to see if Return property is set
        internal bool IsSetReturn()
        {
            return this._return.HasValue; 
        }

    }
}