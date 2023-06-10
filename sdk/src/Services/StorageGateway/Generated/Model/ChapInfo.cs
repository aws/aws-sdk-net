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
    /// Describes Challenge-Handshake Authentication Protocol (CHAP) information that supports
    /// authentication between your gateway and iSCSI initiators.
    /// </summary>
    public partial class ChapInfo
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
        [AWSProperty(Min=1, Max=255)]
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
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=100)]
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
        /// initiator (e.g., Windows client).
        /// </para>
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
        /// The Amazon Resource Name (ARN) of the volume.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: 50 to 500 lowercase letters, numbers, periods (.), and hyphens (-).
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=800)]
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