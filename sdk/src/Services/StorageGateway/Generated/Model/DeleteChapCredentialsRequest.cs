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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
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
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteChapCredentials operation.
    /// Deletes Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
    /// iSCSI target and initiator pair. This operation is supported in volume and tape gateway
    /// types.
    /// </summary>
    public partial class DeleteChapCredentialsRequest : AmazonStorageGatewayRequest
    {
        private string _initiatorName;
        private string _targetARN;

        /// <summary>
        /// Gets and sets the property InitiatorName. 
        /// <para>
        /// The iSCSI initiator that connects to the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string InitiatorName
        {
            get { return this._initiatorName; }
            set { this._initiatorName = value; }
        }

        // Check to see if InitiatorName property is set
        internal bool IsSetInitiatorName()
        {
            return this._initiatorName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the iSCSI volume target. Use the <a>DescribeStorediSCSIVolumes</a>
        /// operation to return to retrieve the TargetARN for specified VolumeARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=800)]
        public string TargetARN
        {
            get { return this._targetARN; }
            set { this._targetARN = value; }
        }

        // Check to see if TargetARN property is set
        internal bool IsSetTargetARN()
        {
            return this._targetARN != null;
        }

    }
}