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
    /// Container for the parameters to the MoveCapacityReservationInstances operation.
    /// Move available capacity from a source Capacity Reservation to a destination Capacity
    /// Reservation. The source Capacity Reservation and the destination Capacity Reservation
    /// must be <c>active</c>, owned by your Amazon Web Services account, and share the following:
    /// 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Instance type
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Platform
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Availability Zone
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tenancy
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Placement group
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Capacity Reservation end time - <c>At specific time</c> or <c>Manually</c>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class MoveCapacityReservationInstancesRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _destinationCapacityReservationId;
        private bool? _dryRun;
        private int? _instanceCount;
        private string _sourceCapacityReservationId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensure
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationCapacityReservationId. 
        /// <para>
        ///  The ID of the Capacity Reservation that you want to move capacity into. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationCapacityReservationId
        {
            get { return this._destinationCapacityReservationId; }
            set { this._destinationCapacityReservationId = value; }
        }

        // Check to see if DestinationCapacityReservationId property is set
        internal bool IsSetDestinationCapacityReservationId()
        {
            return this._destinationCapacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances that you want to move from the source Capacity Reservation.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SourceCapacityReservationId. 
        /// <para>
        ///  The ID of the Capacity Reservation from which you want to move capacity. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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