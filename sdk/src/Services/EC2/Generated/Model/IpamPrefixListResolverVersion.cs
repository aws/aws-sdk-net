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
    /// Describes a version of an IPAM prefix list resolver.
    /// 
    ///  
    /// <para>
    /// Each version is a snapshot of what CIDRs matched your rules at that moment in time.
    /// The version number increments every time the CIDR list changes due to infrastructure
    /// changes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Version example:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Initial State (Version 1)</b> 
    /// </para>
    ///  
    /// <para>
    /// Production environment:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// vpc-prod-web (10.1.0.0/16) - tagged env=prod
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// vpc-prod-db (10.2.0.0/16) - tagged env=prod
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Resolver rule: Include all VPCs tagged env=prod
    /// </para>
    ///  
    /// <para>
    ///  <b>Version 1 CIDRs:</b> 10.1.0.0/16, 10.2.0.0/16
    /// </para>
    ///  
    /// <para>
    ///  <b>Infrastructure Change (Version 2)</b> 
    /// </para>
    ///  
    /// <para>
    /// New VPC added:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// vpc-prod-api (10.3.0.0/16) - tagged env=prod
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// IPAM automatically detects the change and creates a new version.
    /// </para>
    ///  
    /// <para>
    ///  <b>Version 2 CIDRs:</b> 10.1.0.0/16, 10.2.0.0/16, 10.3.0.0/16
    /// </para>
    /// </summary>
    public partial class IpamPrefixListResolverVersion
    {
        private long? _version;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the IPAM prefix list resolver.
        /// </para>
        ///  
        /// <para>
        /// Each version is a snapshot of what CIDRs matched your rules at that moment in time.
        /// The version number increments every time the CIDR list changes due to infrastructure
        /// changes.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}