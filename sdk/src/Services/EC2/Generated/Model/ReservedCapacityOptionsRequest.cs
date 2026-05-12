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
    /// Defines EC2 Fleet preferences for utilizing reserved capacity when DefaultTargetCapacityType
    /// is set to <c>reserved-capacity</c>.
    /// 
    ///  <note> 
    /// <para>
    /// This configuration can only be used if the EC2 Fleet is of type <c>instant</c>.
    /// </para>
    ///  </note> 
    /// <para>
    /// When you specify <c>ReservedCapacityOptions</c>, you must also set <c>DefaultTargetCapacityType</c>
    /// to <c>reserved-capacity</c> in the <c>TargetCapacitySpecification</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information about Interruptible Capacity Reservations, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-launch-instances-interruptible-cr-walkthrough.html">Launch
    /// instances into an Interruptible Capacity Reservation</a> in the <i>Amazon EC2 User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class ReservedCapacityOptionsRequest
    {
        private List<string> _reservationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ReservationTypes. 
        /// <para>
        /// The types of Capacity Reservations to use for fulfilling the EC2 Fleet request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReservationTypes
        {
            get { return this._reservationTypes; }
            set { this._reservationTypes = value; }
        }

        // Check to see if ReservationTypes property is set
        internal bool IsSetReservationTypes()
        {
            return this._reservationTypes != null && (this._reservationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}