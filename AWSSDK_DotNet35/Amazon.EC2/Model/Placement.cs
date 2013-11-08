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
    /// <para> Describes where an Amazon EC2 instance is running within an Amazon EC2 region. </para>
    /// </summary>
    public class Placement
    {
        
        private string availabilityZone;
        private string groupName;
        private Tenancy tenancy;


        /// <summary>
        /// The availability zone in which an Amazon EC2 instance runs.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The name of the <a>PlacementGroup</a> in which an Amazon EC2 instance runs. Placement groups are primarily used for launching High
        /// Performance Computing instances in the same group to ensure fast connection speeds.
        ///  
        /// </summary>
        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this.groupName != null;
        }

        /// <summary>
        /// The allowed tenancy of instances launched into the VPC. A value of default means instances can be launched with any tenancy; a value of
        /// dedicated means all instances launched into the VPC will be launched as dedicated tenancy regardless of the tenancy assigned to the instance
        /// at launch.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>default, dedicated</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Tenancy Tenancy
        {
            get { return this.tenancy; }
            set { this.tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this.tenancy != null;
        }
    }
}
