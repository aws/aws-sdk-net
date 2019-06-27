/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-instance-connect-2018-04-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2InstanceConnect.Model
{
    /// <summary>
    /// Container for the parameters to the SendSSHPublicKey operation.
    /// Pushes an SSH public key to a particular OS user on a given EC2 instance for 60 seconds.
    /// </summary>
    public partial class SendSSHPublicKeyRequest : AmazonEC2InstanceConnectRequest
    {
        private string _availabilityZone;
        private string _instanceId;
        private string _instanceOSUser;
        private string _sshPublicKey;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The availability zone the EC2 instance was launched in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=32)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The EC2 instance you wish to publish the SSH key to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=32)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceOSUser. 
        /// <para>
        /// The OS user on the EC2 instance whom the key may be used to authenticate as.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string InstanceOSUser
        {
            get { return this._instanceOSUser; }
            set { this._instanceOSUser = value; }
        }

        // Check to see if InstanceOSUser property is set
        internal bool IsSetInstanceOSUser()
        {
            return this._instanceOSUser != null;
        }

        /// <summary>
        /// Gets and sets the property SSHPublicKey. 
        /// <para>
        /// The public key to be published to the instance. To use it after publication you must
        /// have the matching private key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=256, Max=4096)]
        public string SSHPublicKey
        {
            get { return this._sshPublicKey; }
            set { this._sshPublicKey = value; }
        }

        // Check to see if SSHPublicKey property is set
        internal bool IsSetSSHPublicKey()
        {
            return this._sshPublicKey != null;
        }

    }
}