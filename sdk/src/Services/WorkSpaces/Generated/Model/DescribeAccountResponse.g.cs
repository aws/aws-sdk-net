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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccount operation.
    /// </summary>
    public partial class DescribeAccountResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DedicatedTenancyAccountType. 
        /// <para>
        /// The type of linked account.
        /// </para>
        /// </summary>
        public DedicatedTenancyAccountType DedicatedTenancyAccountType { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedTenancyAccountType property is set.
        /// </summary>
        internal bool IsSetDedicatedTenancyAccountType() => this.DedicatedTenancyAccountType != null;

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
        public string DedicatedTenancyManagementCidrRange { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedTenancyManagementCidrRange property is set.
        /// </summary>
        internal bool IsSetDedicatedTenancyManagementCidrRange() => this.DedicatedTenancyManagementCidrRange != null;

        /// <summary>
        /// Gets and sets the property DedicatedTenancySupport. 
        /// <para>
        /// The status of BYOL (whether BYOL is enabled or disabled).
        /// </para>
        /// </summary>
        public DedicatedTenancySupportResultEnum DedicatedTenancySupport { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedTenancySupport property is set.
        /// </summary>
        internal bool IsSetDedicatedTenancySupport() => this.DedicatedTenancySupport != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The text message to describe the status of BYOL.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
