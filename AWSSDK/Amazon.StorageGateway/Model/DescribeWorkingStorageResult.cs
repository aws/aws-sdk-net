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
    /// <li> DescribeWorkingStorageOutput$DiskIds </li>
    /// <li> GatewayARN </li>
    /// <li> DescribeWorkingStorageOutput$WorkingStorageAllocatedInBytes </li>
    /// <li> DescribeWorkingStorageOutput$WorkingStorageUsedInBytes </li>
    /// 
    /// </ul>
    /// </summary>
    public class DescribeWorkingStorageResult  
    {
        
        private string gatewayARN;
        private List<string> diskIds = new List<string>();
        private long? workingStorageUsedInBytes;
        private long? workingStorageAllocatedInBytes;

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
        public DescribeWorkingStorageResult WithGatewayARN(string gatewayARN)
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
        /// An array of the gateway's local disk IDs that are configured as working storage. Each local disk ID is specified as a string (minimum length
        /// of 1 and maximum length of 300). If no local disks are configured as working storage, then the DiskIds array is empty.
        ///  
        /// </summary>
        public List<string> DiskIds
        {
            get { return this.diskIds; }
            set { this.diskIds = value; }
        }
        /// <summary>
        /// Adds elements to the DiskIds collection
        /// </summary>
        /// <param name="diskIds">The values to add to the DiskIds collection </param>
        /// <returns>this instance</returns>
        public DescribeWorkingStorageResult WithDiskIds(params string[] diskIds)
        {
            foreach (string element in diskIds)
            {
                this.diskIds.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the DiskIds collection
        /// </summary>
        /// <param name="diskIds">The values to add to the DiskIds collection </param>
        /// <returns>this instance</returns>
        public DescribeWorkingStorageResult WithDiskIds(IEnumerable<string> diskIds)
        {
            foreach (string element in diskIds)
            {
                this.diskIds.Add(element);
            }

            return this;
        }

        // Check to see if DiskIds property is set
        internal bool IsSetDiskIds()
        {
            return this.diskIds.Count > 0;       
        }

        /// <summary>
        /// The total working storage in bytes in use by the gateway. If no working storage is configured for the gateway, this field returns 0.
        ///  
        /// </summary>
        public long WorkingStorageUsedInBytes
        {
            get { return this.workingStorageUsedInBytes ?? default(long); }
            set { this.workingStorageUsedInBytes = value; }
        }

        /// <summary>
        /// Sets the WorkingStorageUsedInBytes property
        /// </summary>
        /// <param name="workingStorageUsedInBytes">The value to set for the WorkingStorageUsedInBytes property </param>
        /// <returns>this instance</returns>
        public DescribeWorkingStorageResult WithWorkingStorageUsedInBytes(long workingStorageUsedInBytes)
        {
            this.workingStorageUsedInBytes = workingStorageUsedInBytes;
            return this;
        }
            

        // Check to see if WorkingStorageUsedInBytes property is set
        internal bool IsSetWorkingStorageUsedInBytes()
        {
            return this.workingStorageUsedInBytes.HasValue;       
        }

        /// <summary>
        /// The total working storage in bytes allocated for the gateway. If no working storage is configured for the gateway, this field returns 0.
        ///  
        /// </summary>
        public long WorkingStorageAllocatedInBytes
        {
            get { return this.workingStorageAllocatedInBytes ?? default(long); }
            set { this.workingStorageAllocatedInBytes = value; }
        }

        /// <summary>
        /// Sets the WorkingStorageAllocatedInBytes property
        /// </summary>
        /// <param name="workingStorageAllocatedInBytes">The value to set for the WorkingStorageAllocatedInBytes property </param>
        /// <returns>this instance</returns>
        public DescribeWorkingStorageResult WithWorkingStorageAllocatedInBytes(long workingStorageAllocatedInBytes)
        {
            this.workingStorageAllocatedInBytes = workingStorageAllocatedInBytes;
            return this;
        }
            

        // Check to see if WorkingStorageAllocatedInBytes property is set
        internal bool IsSetWorkingStorageAllocatedInBytes()
        {
            return this.workingStorageAllocatedInBytes.HasValue;       
        }
    }
}
