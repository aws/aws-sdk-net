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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
        private string _dedicatedHostId;
        private string _hostName;
        private InstanceType _instanceType;
        private string _keyName;
        private string _placementGroupId;

        /// <summary>
        /// Gets and sets the property DedicatedHostId. 
        /// <para>
        /// The unique ID of the Amazon EC2 Dedicated Host.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string DedicatedHostId
        {
            get { return this._dedicatedHostId; }
            set { this._dedicatedHostId = value; }
        }

        // Check to see if DedicatedHostId property is set
        internal bool IsSetDedicatedHostId()
        {
            return this._dedicatedHostId != null;
        }

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The DNS hostname of the host. DNS hostnames for hosts must be unique across Amazon
        /// EVS environments and within VCF.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HostName
        {
            get { return this._hostName; }
            set { this._hostName = value; }
        }

        // Check to see if HostName property is set
        internal bool IsSetHostName()
        {
            return this._hostName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The EC2 instance type that represents the host.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the SSH key that is used to access the host.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property PlacementGroupId. 
        /// <para>
        /// The unique ID of the placement group where the host is placed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string PlacementGroupId
        {
            get { return this._placementGroupId; }
            set { this._placementGroupId = value; }
        }

        // Check to see if PlacementGroupId property is set
        internal bool IsSetPlacementGroupId()
        {
            return this._placementGroupId != null;
        }

    }
}