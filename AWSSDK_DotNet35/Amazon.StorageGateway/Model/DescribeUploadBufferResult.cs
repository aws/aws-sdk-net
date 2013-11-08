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
using Amazon.Runtime;

namespace Amazon.StorageGateway.Model
{
    /// <summary>Describe Upload Buffer Result
    /// </summary>
    public partial class DescribeUploadBufferResult : AmazonWebServiceResponse
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

        // Check to see if UploadBufferAllocatedInBytes property is set
        internal bool IsSetUploadBufferAllocatedInBytes()
        {
            return this.uploadBufferAllocatedInBytes.HasValue;
        }
    }
}
