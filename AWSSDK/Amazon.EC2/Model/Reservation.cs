/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Reservation information.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class Reservation
    {    
        private string reservationIdField;
        private string ownerIdField;
        private string requesterIdField;
        private List<string> groupIdField;
        private List<string> groupNameField;
        private List<RunningInstance> runningInstanceField;

        /// <summary>
        /// Unique ID of the reservation.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservationId")]
        public string ReservationId
        {
            get { return this.reservationIdField; }
            set { this.reservationIdField = value; }
        }

        /// <summary>
        /// Sets the unique ID of the reservation.
        /// </summary>
        /// <param name="reservationId">Unique ID of the reservation.</param>
        /// <returns>this instance</returns>
        public Reservation WithReservationId(string reservationId)
        {
            this.reservationIdField = reservationId;
            return this;
        }

        /// <summary>
        /// Checks if ReservationId property is set
        /// </summary>
        /// <returns>true if ReservationId property is set</returns>
        public bool IsSetReservationId()
        {
            return this.reservationIdField != null;
        }

        /// <summary>
        /// AWS Access Key ID of the user who owns the reservation
        /// </summary>
        [XmlElementAttribute(ElementName = "OwnerId")]
        public string OwnerId
        {
            get { return this.ownerIdField; }
            set { this.ownerIdField = value; }
        }

        /// <summary>
        /// Sets the AWS Access Key ID of the user who owns the reservation
        /// </summary>
        /// <param name="ownerId">AWS Access Key ID of the user who owns the
        /// reservation</param>
        /// <returns>this instance</returns>
        public Reservation WithOwnerId(string ownerId)
        {
            this.ownerIdField = ownerId;
            return this;
        }

        /// <summary>
        /// Checks if OwnerId property is set
        /// </summary>
        /// <returns>true if OwnerId property is set</returns>
        public bool IsSetOwnerId()
        {
            return this.ownerIdField != null;
        }

        /// <summary>
        /// ID of the requester.
        /// </summary>
        [XmlElementAttribute(ElementName = "RequesterId")]
        public string RequesterId
        {
            get { return this.requesterIdField; }
            set { this.requesterIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the requester.
        /// </summary>
        /// <param name="requesterId">ID of the requester.</param>
        /// <returns>this instance</returns>
        public Reservation WithRequesterId(string requesterId)
        {
            this.requesterIdField = requesterId;
            return this;
        }

        /// <summary>
        /// Checks if RequesterId property is set
        /// </summary>
        /// <returns>true if RequesterId property is set</returns>
        public bool IsSetRequesterId()
        {
            return this.requesterIdField != null;
        }

        /// <summary>
        /// Security group IDs for the reservation.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupId")]
        public List<string> GroupId
        {
            get
            {
                if (this.groupIdField == null)
                {
                    this.groupIdField = new List<string>();
                }
                return this.groupIdField;
            }
            set { this.groupIdField = value; }
        }

        /// <summary>
        /// Sets the security group IDs for the reservation.
        /// </summary>
        /// <param name="list">Ids of the security groups.</param>
        /// <returns>this instance</returns>
        public Reservation WithGroupId(params string[] list)
        {
            foreach (string item in list)
            {
                GroupId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if GroupId property is set
        /// </summary>
        /// <returns>true if GroupId property is set</returns>
        public bool IsSetGroupId()
        {
            return (GroupId.Count > 0);
        }

        /// <summary>
        /// Security group names for the reservation.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupName")]
        public List<string> GroupName
        {
            get
            {
                if (this.groupNameField == null)
                {
                    this.groupNameField = new List<string>();
                }
                return this.groupNameField;
            }
            set { this.groupNameField = value; }
        }

        /// <summary>
        /// Sets the security group names for the reservation.
        /// </summary>
        /// <param name="list">Names of the security groups.</param>
        /// <returns>this instance</returns>
        public Reservation WithGroupName(params string[] list)
        {
            foreach (string item in list)
            {
                GroupName.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if GroupName property is set
        /// </summary>
        /// <returns>true if GroupName property is set</returns>
        public bool IsSetGroupName()
        {
            return (GroupName.Count > 0);
        }

        /// <summary>
        /// Running instances
        /// </summary>
        [XmlElementAttribute(ElementName = "RunningInstance")]
        public List<RunningInstance> RunningInstance
        {
            get
            {
                if (this.runningInstanceField == null)
                {
                    this.runningInstanceField = new List<RunningInstance>();
                }
                return this.runningInstanceField;
            }
            set { this.runningInstanceField = value; }
        }

        /// <summary>
        /// Sets the running instances
        /// </summary>
        /// <param name="list">Running instance</param>
        /// <returns>this instance</returns>
        public Reservation WithRunningInstance(params RunningInstance[] list)
        {
            foreach (RunningInstance item in list)
            {
                RunningInstance.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if RunningInstance property is set
        /// </summary>
        /// <returns>true if RunningInstance property is set</returns>
        public bool IsSetRunningInstance()
        {
            return (RunningInstance.Count > 0);
        }

    }
}
