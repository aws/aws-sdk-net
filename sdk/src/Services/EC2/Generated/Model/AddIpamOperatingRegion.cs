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
    /// Add an operating Region to an IPAM. Operating Regions are Amazon Web Services Regions
    /// where the IPAM is allowed to manage IP address CIDRs. IPAM only discovers and monitors
    /// resources in the Amazon Web Services Regions you select as operating Regions.
    /// 
    ///  
    /// <para>
    /// For more information about operating Regions, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/create-ipam.html">Create
    /// an IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class AddIpamOperatingRegion
    {
        private string _regionName;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The name of the operating Region.
        /// </para>
        /// </summary>
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

    }
}