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
    /// This is the response object from the DescribeAccount operation.
    /// </summary>
    public partial class DescribeAccountResponse : AmazonWebServiceResponse
    {
        private DedicatedTenancyAccountType _dedicatedTenancyAccountType;
        private string _dedicatedTenancyManagementCidrRange;
        private DedicatedTenancySupportResultEnum _dedicatedTenancySupport;
        private string _message;

        /// <summary>
        /// Gets and sets the property DedicatedTenancyAccountType. 
        /// <para>
        /// The type of linked account.
        /// </para>
        /// </summary>
        public DedicatedTenancyAccountType DedicatedTenancyAccountType
        {
            get { return this._dedicatedTenancyAccountType; }
            set { this._dedicatedTenancyAccountType = value; }
        }

        // Check to see if DedicatedTenancyAccountType property is set
        internal bool IsSetDedicatedTenancyAccountType()
        {
            return this._dedicatedTenancyAccountType != null;
        }

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

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The text message to describe the status of BYOL.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}