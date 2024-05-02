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
    /// Describes address usage for a customer-owned address pool.
    /// </summary>
    public partial class CoipAddressUsage
    {
        private string _allocationId;
        private string _awsAccountId;
        private string _awsService;
        private string _coIp;

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The allocation ID of the address.
        /// </para>
        /// </summary>
        public string AllocationId
        {
            get { return this._allocationId; }
            set { this._allocationId = value; }
        }

        // Check to see if AllocationId property is set
        internal bool IsSetAllocationId()
        {
            return this._allocationId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsService. 
        /// <para>
        /// The Amazon Web Services service.
        /// </para>
        /// </summary>
        public string AwsService
        {
            get { return this._awsService; }
            set { this._awsService = value; }
        }

        // Check to see if AwsService property is set
        internal bool IsSetAwsService()
        {
            return this._awsService != null;
        }

        /// <summary>
        /// Gets and sets the property CoIp. 
        /// <para>
        /// The customer-owned IP address.
        /// </para>
        /// </summary>
        public string CoIp
        {
            get { return this._coIp; }
            set { this._coIp = value; }
        }

        // Check to see if CoIp property is set
        internal bool IsSetCoIp()
        {
            return this._coIp != null;
        }

    }
}