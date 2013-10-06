/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing the following fields:</para>
    /// <ul>
    /// <li> ListLocalDisksOutput$Disks </li>
    /// <li> GatewayARN </li>
    /// 
    /// </ul>
    /// </summary>
    public class ListLocalDisksResult  
    {
        
        private string gatewayARN;
        private List<Disk> disks = new List<Disk>();

        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway. Use the <a>ListGateways</a> operation to return a list of gateways for your account and
        /// region.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 500</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GatewayARN
        {
            get { return this.gatewayARN; }
            set { this.gatewayARN = value; }
        }

        /// <summary>
        /// Sets the GatewayARN property
        /// </summary>
        /// <param name="gatewayARN">The value to set for the GatewayARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListLocalDisksResult WithGatewayARN(string gatewayARN)
        {
            this.gatewayARN = gatewayARN;
            return this;
        }
            

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;       
        }

        /// <summary>
        /// An array of <a>Disk</a> objects.
        ///  
        /// </summary>
        public List<Disk> Disks
        {
            get { return this.disks; }
            set { this.disks = value; }
        }
        /// <summary>
        /// Adds elements to the Disks collection
        /// </summary>
        /// <param name="disks">The values to add to the Disks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListLocalDisksResult WithDisks(params Disk[] disks)
        {
            foreach (Disk element in disks)
            {
                this.disks.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Disks collection
        /// </summary>
        /// <param name="disks">The values to add to the Disks collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListLocalDisksResult WithDisks(IEnumerable<Disk> disks)
        {
            foreach (Disk element in disks)
            {
                this.disks.Add(element);
            }

            return this;
        }

        // Check to see if Disks property is set
        internal bool IsSetDisks()
        {
            return this.disks.Count > 0;       
        }
    }
}
