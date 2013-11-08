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
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeChapCredentials operation.
    /// <para>This operation returns an array of Challenge-Handshake Authentication Protocol (CHAP) credentials information for a specified iSCSI
    /// target, one for each target-initiator pair.</para>
    /// </summary>
    public partial class DescribeChapCredentialsRequest : AmazonStorageGatewayRequest
    {
        private string targetARN;


        /// <summary>
        /// The Amazon Resource Name (ARN) of the iSCSI volume target. Use the <a>DescribeStorediSCSIVolumes</a> operation to return to retrieve the
        /// TargetARN for specified VolumeARN.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>50 - 800</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TargetARN
        {
            get { return this.targetARN; }
            set { this.targetARN = value; }
        }

        // Check to see if TargetARN property is set
        internal bool IsSetTargetARN()
        {
            return this.targetARN != null;
        }

    }
}
    
