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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyAccount operation.
    /// Modifies the configuration of Bring Your Own License (BYOL) for the specified account.
    /// </summary>
    public partial class ModifyAccountRequest : AmazonWorkSpacesRequest
    {
        private string _dedicatedTenancyManagementCidrRange;
        private DedicatedTenancySupportEnum _dedicatedTenancySupport;

        /// <summary>
        /// Gets and sets the property DedicatedTenancyManagementCidrRange. 
        /// <para>
        /// The IP address range, specified as an IPv4 CIDR block, for the management network
        /// interface. Specify an IP address range that is compatible with your network and in
        /// CIDR notation (that is, specify the range as an IPv4 CIDR block). The CIDR block size
        /// must be /16 (for example, 203.0.113.25/16). It must also be specified as available
        /// by the <c>ListAvailableManagementCidrRanges</c> operation.
        /// </para>
        /// </summary>
        public string DedicatedTenancyManagementCidrRange
        {
            get { return this._dedicatedTenancyManagementCidrRange; }
            set { this._dedicatedTenancyManagementCidrRange = value; }
        }

        // Check to see if DedicatedTenancyManagementCidrRange property is set
        internal bool IsSetDedicatedTenancyManagementCidrRange()
        {
            return this._dedicatedTenancyManagementCidrRange != null;
        }

        /// <summary>
        /// Gets and sets the property DedicatedTenancySupport. 
        /// <para>
        /// The status of BYOL.
        /// </para>
        /// </summary>
        public DedicatedTenancySupportEnum DedicatedTenancySupport
        {
            get { return this._dedicatedTenancySupport; }
            set { this._dedicatedTenancySupport = value; }
        }

        // Check to see if DedicatedTenancySupport property is set
        internal bool IsSetDedicatedTenancySupport()
        {
            return this._dedicatedTenancySupport != null;
        }

    }
}