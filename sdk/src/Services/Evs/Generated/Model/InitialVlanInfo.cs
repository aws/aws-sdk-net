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
    /// An object that represents an initial VLAN subnet for the Amazon EVS environment. Amazon
    /// EVS creates initial VLAN subnets when you first create the environment. Amazon EVS
    /// creates the following 10 VLAN subnets: host management VLAN, vMotion VLAN, vSAN VLAN,
    /// VTEP VLAN, Edge VTEP VLAN, Management VM VLAN, HCX uplink VLAN, NSX uplink VLAN, expansion
    /// VLAN 1, expansion VLAN 2.
    /// 
    ///  <note> 
    /// <para>
    /// For each Amazon EVS VLAN subnet, you must specify a non-overlapping CIDR block. Amazon
    /// EVS VLAN subnets have a minimum CIDR block size of /28 and a maximum size of /24.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InitialVlanInfo
    {
        private string _cidr;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        ///  The CIDR block that you provide to create an Amazon EVS VLAN subnet. Amazon EVS VLAN
        /// subnets have a minimum CIDR block size of /28 and a maximum size of /24. Amazon EVS
        /// VLAN subnet CIDR blocks must not overlap with other subnets in the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

    }
}