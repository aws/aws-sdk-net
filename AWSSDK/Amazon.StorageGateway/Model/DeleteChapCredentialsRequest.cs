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
    /// Container for the parameters to the DeleteChapCredentials operation.
    /// <para>This operation deletes Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified iSCSI target and initiator
    /// pair.</para>
    /// </summary>
    /// <seealso cref="Amazon.StorageGateway.AmazonStorageGateway.DeleteChapCredentials"/>
    public class DeleteChapCredentialsRequest : AmazonWebServiceRequest
    {
        private string targetARN;
        private string initiatorName;

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

        /// <summary>
        /// Sets the TargetARN property
        /// </summary>
        /// <param name="targetARN">The value to set for the TargetARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteChapCredentialsRequest WithTargetARN(string targetARN)
        {
            this.targetARN = targetARN;
            return this;
        }
            

        // Check to see if TargetARN property is set
        internal bool IsSetTargetARN()
        {
            return this.targetARN != null;       
        }

        /// <summary>
        /// The iSCSI initiator that connects to the target.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[0-9a-z:.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InitiatorName
        {
            get { return this.initiatorName; }
            set { this.initiatorName = value; }
        }

        /// <summary>
        /// Sets the InitiatorName property
        /// </summary>
        /// <param name="initiatorName">The value to set for the InitiatorName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteChapCredentialsRequest WithInitiatorName(string initiatorName)
        {
            this.initiatorName = initiatorName;
            return this;
        }
            

        // Check to see if InitiatorName property is set
        internal bool IsSetInitiatorName()
        {
            return this.initiatorName != null;       
        }
    }
}
    
