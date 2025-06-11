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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// The EC2 capacity reservations that are shared to an ML capacity reservation.
    /// </summary>
    public partial class Ec2CapacityReservation
    {
        private int? _availableInstanceCount;
        private string _ec2CapacityReservationId;
        private int? _totalInstanceCount;
        private int? _usedByCurrentEndpoint;

        /// <summary>
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of instances that are currently available in the EC2 capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AvailableInstanceCount
        {
            get { return this._availableInstanceCount; }
            set { this._availableInstanceCount = value; }
        }

        // Check to see if AvailableInstanceCount property is set
        internal bool IsSetAvailableInstanceCount()
        {
            return this._availableInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ec2CapacityReservationId. 
        /// <para>
        /// The unique identifier for an EC2 capacity reservation that's part of the ML capacity
        /// reservation.
        /// </para>
        /// </summary>
        public string Ec2CapacityReservationId
        {
            get { return this._ec2CapacityReservationId; }
            set { this._ec2CapacityReservationId = value; }
        }

        // Check to see if Ec2CapacityReservationId property is set
        internal bool IsSetEc2CapacityReservationId()
        {
            return this._ec2CapacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property TotalInstanceCount. 
        /// <para>
        /// The number of instances that you allocated to the EC2 capacity reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TotalInstanceCount
        {
            get { return this._totalInstanceCount; }
            set { this._totalInstanceCount = value; }
        }

        // Check to see if TotalInstanceCount property is set
        internal bool IsSetTotalInstanceCount()
        {
            return this._totalInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UsedByCurrentEndpoint. 
        /// <para>
        /// The number of instances from the EC2 capacity reservation that are being used by the
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? UsedByCurrentEndpoint
        {
            get { return this._usedByCurrentEndpoint; }
            set { this._usedByCurrentEndpoint = value; }
        }

        // Check to see if UsedByCurrentEndpoint property is set
        internal bool IsSetUsedByCurrentEndpoint()
        {
            return this._usedByCurrentEndpoint.HasValue; 
        }

    }
}