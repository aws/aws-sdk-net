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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// An object that represents a host.
    /// 
    ///  <note> 
    /// <para>
    /// You cannot use <c>dedicatedHostId</c> and <c>placementGroupId</c> together in the
    /// same <c>HostInfoForCreate</c>object. This results in a <c>ValidationException</c>
    /// response.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class HostInfoForCreate
    {
        /// <summary>
        /// Gets and sets the property DedicatedHostId. 
        /// <para>
        /// The unique ID of the Amazon EC2 Dedicated Host.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedHostId property is set.
        /// </summary>
        internal bool IsSetDedicatedHostId() => this.DedicatedHostId != null;

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The DNS hostname of the host. DNS hostnames for hosts must be unique across Amazon
        /// EVS environments and within VCF.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HostName { get; set; }

        /// <summary>
        /// Checks to see if the HostName property is set.
        /// </summary>
        internal bool IsSetHostName() => this.HostName != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The EC2 instance type that represents the host.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the SSH key that is used to access the host.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property PlacementGroupId. 
        /// <para>
        /// The unique ID of the placement group where the host is placed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string PlacementGroupId { get; set; }

        /// <summary>
        /// Checks to see if the PlacementGroupId property is set.
        /// </summary>
        internal bool IsSetPlacementGroupId() => this.PlacementGroupId != null;
    }
}
