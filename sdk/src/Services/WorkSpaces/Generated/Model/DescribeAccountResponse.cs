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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccount operation.
    /// </summary>
    public partial class DescribeAccountResponse : AmazonWebServiceResponse
    {
        private string _dedicatedTenancyManagementCidrRange;
        private DedicatedTenancySupportResultEnum _dedicatedTenancySupport;

        /// <summary>
        /// Gets and sets the property DedicatedTenancyManagementCidrRange. 
        /// <para>
        /// The IP address range, specified as an IPv4 CIDR block, used for the management network
        /// interface.
        /// </para>
        ///  
        /// <para>
        /// The management network interface is connected to a secure Amazon WorkSpaces management
        /// network. It is used for interactive streaming of the WorkSpace desktop to Amazon WorkSpaces
        /// clients, and to allow Amazon WorkSpaces to manage the WorkSpace.
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
        /// The status of BYOL (whether BYOL is enabled or disabled).
        /// </para>
        /// </summary>
        public DedicatedTenancySupportResultEnum DedicatedTenancySupport
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