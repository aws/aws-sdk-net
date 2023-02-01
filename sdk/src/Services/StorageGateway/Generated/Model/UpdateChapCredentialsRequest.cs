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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateChapCredentials operation.
    /// Updates the Challenge-Handshake Authentication Protocol (CHAP) credentials for a specified
    /// iSCSI target. By default, a gateway does not have CHAP enabled; however, for added
    /// security, you might use it. This operation is supported in the volume and tape gateway
    /// types.
    /// 
    ///  <important> 
    /// <para>
    /// When you update CHAP credentials, all existing connections on the target are closed
    /// and initiators must reconnect with the new credentials.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateChapCredentialsRequest : AmazonStorageGatewayRequest
    {
        private string _initiatorName;
        private string _secretToAuthenticateInitiator;
        private string _secretToAuthenticateTarget;
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
        /// Gets and sets the property SecretToAuthenticateInitiator. 
        /// <para>
        /// The secret key that the initiator (for example, the Windows client) must provide to
        /// participate in mutual CHAP with the target.
        /// </para>
        ///  <note> 
        /// <para>
        /// The secret key must be between 12 and 16 bytes when encoded in UTF-8.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=100)]
        public string SecretToAuthenticateInitiator
        {
            get { return this._secretToAuthenticateInitiator; }
            set { this._secretToAuthenticateInitiator = value; }
        }

        // Check to see if SecretToAuthenticateInitiator property is set
        internal bool IsSetSecretToAuthenticateInitiator()
        {
            return this._secretToAuthenticateInitiator != null;
        }

        /// <summary>
        /// Gets and sets the property SecretToAuthenticateTarget. 
        /// <para>
        /// The secret key that the target must provide to participate in mutual CHAP with the
        /// initiator (e.g. Windows client).
        /// </para>
        ///  
        /// <para>
        /// Byte constraints: Minimum bytes of 12. Maximum bytes of 16.
        /// </para>
        ///  <note> 
        /// <para>
        /// The secret key must be between 12 and 16 bytes when encoded in UTF-8.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
        public string SecretToAuthenticateTarget
        {
            get { return this._secretToAuthenticateTarget; }
            set { this._secretToAuthenticateTarget = value; }
        }

        // Check to see if SecretToAuthenticateTarget property is set
        internal bool IsSetSecretToAuthenticateTarget()
        {
            return this._secretToAuthenticateTarget != null;
        }

        /// <summary>
        /// Gets and sets the property TargetARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the iSCSI volume target. Use the <a>DescribeStorediSCSIVolumes</a>
        /// operation to return the TargetARN for specified VolumeARN.
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