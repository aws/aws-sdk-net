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
 * Do not modify this file. This file is generated from the ec2-instance-connect-2018-04-02.normal.json service model.
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
namespace Amazon.EC2InstanceConnect.Model
{
    /// <summary>
    /// Container for the parameters to the SendSerialConsoleSSHPublicKey operation.
    /// Pushes an SSH public key to the specified EC2 instance. The key remains for 60 seconds,
    /// which gives you 60 seconds to establish a serial console connection to the instance
    /// using SSH. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-serial-console.html">EC2
    /// Serial Console</a> in the <i>Amazon EC2 User Guide</i>.
    /// </summary>
    public partial class SendSerialConsoleSSHPublicKeyRequest : AmazonEC2InstanceConnectRequest
    {
        private string _instanceId;
        private int? _serialPort;
        private string _sshPublicKey;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the EC2 instance.
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
        /// Gets and sets the property SerialPort. 
        /// <para>
        /// The serial port of the EC2 instance. Currently only port 0 is supported.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=0)]
        public int? SerialPort
        {
            get { return this._serialPort; }
            set { this._serialPort = value; }
        }

        // Check to see if SerialPort property is set
        internal bool IsSetSerialPort()
        {
            return this._serialPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SSHPublicKey. 
        /// <para>
        /// The public key material. To use the public key, you must have the matching private
        /// key. For information about the supported key formats and lengths, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html#how-to-generate-your-own-key-and-import-it-to-aws">Requirements
        /// for key pairs</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=80, Max=4096)]
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