/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> An Amazon EC2 reservation of requested EC2 instances. </para>
    /// </summary>
    public class Reservation
    {
        
        private string reservationId;
        private string ownerId;
        private string requesterId;
        private List<GroupIdentifier> groups = new List<GroupIdentifier>();
        private List<string> groupNames = new List<string>();
        private List<Instance> instances = new List<Instance>();


        /// <summary>
        /// The unique ID of this reservation.
        ///  
        /// </summary>
        public string ReservationId
        {
            get { return this.reservationId; }
            set { this.reservationId = value; }
        }

        // Check to see if ReservationId property is set
        internal bool IsSetReservationId()
        {
            return this.reservationId != null;
        }

        /// <summary>
        /// The AWS Access Key ID of the user who owns the reservation.
        ///  
        /// </summary>
        public string OwnerId
        {
            get { return this.ownerId; }
            set { this.ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this.ownerId != null;
        }

        /// <summary>
        /// The unique ID of the user who requested the instances in this reservation.
        ///  
        /// </summary>
        public string RequesterId
        {
            get { return this.requesterId; }
            set { this.requesterId = value; }
        }

        // Check to see if RequesterId property is set
        internal bool IsSetRequesterId()
        {
            return this.requesterId != null;
        }

        /// <summary>
        /// The list of security groups requested for the instances in this reservation.
        ///  
        /// </summary>
        public List<GroupIdentifier> Groups
        {
            get { return this.groups; }
            set { this.groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this.groups.Count > 0;
        }

        /// <summary>
        /// The list of security groups requested for the instances in this reservation.
        ///  
        /// </summary>
        public List<string> GroupNames
        {
            get { return this.groupNames; }
            set { this.groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this.groupNames.Count > 0;
        }

        /// <summary>
        /// The list of Amazon EC2 instances included in this reservation.
        ///  
        /// </summary>
        public List<Instance> Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this.instances.Count > 0;
        }
    }
}
