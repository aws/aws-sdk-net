/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a reservation.
    /// </summary>
    public partial class Reservation
    {
        private List<string> _groupNames = new List<string>();
        private List<GroupIdentifier> _groups = new List<GroupIdentifier>();
        private List<Instance> _instances = new List<Instance>();
        private string _ownerId;
        private string _requesterId;
        private string _reservationId;

        /// <summary>
        /// Gets and sets the property GroupNames. 
        /// <para>
        /// One or more security group names.
        /// </para>
        /// </summary>
        public List<string> GroupNames
        {
            get { return this._groupNames; }
            set { this._groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this._groupNames != null && this._groupNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// One or more security groups.
        /// </para>
        /// </summary>
        public List<GroupIdentifier> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// One or more instances.
        /// </para>
        /// </summary>
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the AWS account that owns the reservation.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property RequesterId. 
        /// <para>
        /// The ID of the requester that launched the instances on your behalf (for example, AWS
        /// Management Console or Auto Scaling).
        /// </para>
        /// </summary>
        public string RequesterId
        {
            get { return this._requesterId; }
            set { this._requesterId = value; }
        }

        // Check to see if RequesterId property is set
        internal bool IsSetRequesterId()
        {
            return this._requesterId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationId. 
        /// <para>
        /// The ID of the reservation.
        /// </para>
        /// </summary>
        public string ReservationId
        {
            get { return this._reservationId; }
            set { this._reservationId = value; }
        }

        // Check to see if ReservationId property is set
        internal bool IsSetReservationId()
        {
            return this._reservationId != null;
        }

    }
}