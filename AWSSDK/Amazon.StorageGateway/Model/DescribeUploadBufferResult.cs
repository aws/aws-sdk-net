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
    /// <summary>Describe Upload Buffer Result
    /// </summary>
    public partial class DescribeUploadBufferResult
    {
        
        private string gatewayARN;
        private List<string> diskIds = new List<string>();
        private long? uploadBufferUsedInBytes;
        private long? uploadBufferAllocatedInBytes;

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
        public DescribeUploadBufferResult WithGatewayARN(string gatewayARN)
        {
            this.gatewayARN = gatewayARN;
            return this;
        }
            

        // Check to see if GatewayARN property is set
        internal bool IsSetGatewayARN()
        {
            return this.gatewayARN != null;
        }
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeUploadBufferResult WithDiskIds(params string[] diskIds)
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeUploadBufferResult WithDiskIds(IEnumerable<string> diskIds)
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
        public long UploadBufferUsedInBytes
        {
            get { return this.uploadBufferUsedInBytes ?? default(long); }
            set { this.uploadBufferUsedInBytes = value; }
        }

        /// <summary>
        /// Sets the UploadBufferUsedInBytes property
        /// </summary>
        /// <param name="uploadBufferUsedInBytes">The value to set for the UploadBufferUsedInBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeUploadBufferResult WithUploadBufferUsedInBytes(long uploadBufferUsedInBytes)
        {
            this.uploadBufferUsedInBytes = uploadBufferUsedInBytes;
            return this;
        }
            

        // Check to see if UploadBufferUsedInBytes property is set
        internal bool IsSetUploadBufferUsedInBytes()
        {
            return this.uploadBufferUsedInBytes.HasValue;
        }
        public long UploadBufferAllocatedInBytes
        {
            get { return this.uploadBufferAllocatedInBytes ?? default(long); }
            set { this.uploadBufferAllocatedInBytes = value; }
        }

        /// <summary>
        /// Sets the UploadBufferAllocatedInBytes property
        /// </summary>
        /// <param name="uploadBufferAllocatedInBytes">The value to set for the UploadBufferAllocatedInBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeUploadBufferResult WithUploadBufferAllocatedInBytes(long uploadBufferAllocatedInBytes)
        {
            this.uploadBufferAllocatedInBytes = uploadBufferAllocatedInBytes;
            return this;
        }
            

        // Check to see if UploadBufferAllocatedInBytes property is set
        internal bool IsSetUploadBufferAllocatedInBytes()
        {
            return this.uploadBufferAllocatedInBytes.HasValue;
        }
    }
}
