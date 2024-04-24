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
    /// This is the response object from the ProvisionPublicIpv4PoolCidr operation.
    /// </summary>
    public partial class ProvisionPublicIpv4PoolCidrResponse : AmazonWebServiceResponse
    {
        private PublicIpv4PoolRange _poolAddressRange;
        private string _poolId;

        /// <summary>
        /// Gets and sets the property PoolAddressRange. 
        /// <para>
        /// Information about the address range of the public IPv4 pool.
        /// </para>
        /// </summary>
        public PublicIpv4PoolRange PoolAddressRange
        {
            get { return this._poolAddressRange; }
            set { this._poolAddressRange = value; }
        }

        // Check to see if PoolAddressRange property is set
        internal bool IsSetPoolAddressRange()
        {
            return this._poolAddressRange != null;
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The ID of the pool that you want to provision the CIDR to.
        /// </para>
        /// </summary>
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

    }
}