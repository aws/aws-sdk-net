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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterInstance operation.
    /// Registers instances that were created outside of AWS OpsWorks Stacks with a specified
    /// stack.
    /// 
    ///  <note> 
    /// <para>
    /// We do not recommend using this action to register instances. The complete registration
    /// operation includes two tasks: installing the AWS OpsWorks Stacks agent on the instance,
    /// and registering the instance with the stack. <code>RegisterInstance</code> handles
    /// only the second step. You should instead use the AWS CLI <code>register</code> command,
    /// which performs the entire registration operation. For more information, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/registered-instances-register.html">
    /// Registering an Instance with an AWS OpsWorks Stacks Stack</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Registered instances have the same requirements as instances that are created by using
    /// the <a>CreateInstance</a> API. For example, registered instances must be running a
    /// supported Linux-based operating system, and they must have a supported instance type.
    /// For more information about requirements for instances that you want to register, see
    /// <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/registered-instances-register-registering-preparer.html">
    /// Preparing the Instance</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack or an attached policy that explicitly grants permissions. For
    /// more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class RegisterInstanceRequest : AmazonOpsWorksRequest
    {
        private string _hostname;
        private InstanceIdentity _instanceIdentity;
        private string _privateIp;
        private string _publicIp;
        private string _rsaPublicKey;
        private string _rsaPublicKeyFingerprint;
        private string _stackId;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The instance's hostname.
        /// </para>
        /// </summary>
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceIdentity. 
        /// <para>
        /// An InstanceIdentity object that contains the instance's identity.
        /// </para>
        /// </summary>
        public InstanceIdentity InstanceIdentity
        {
            get { return this._instanceIdentity; }
            set { this._instanceIdentity = value; }
        }

        // Check to see if InstanceIdentity property is set
        internal bool IsSetInstanceIdentity()
        {
            return this._instanceIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIp. 
        /// <para>
        /// The instance's private IP address.
        /// </para>
        /// </summary>
        public string PrivateIp
        {
            get { return this._privateIp; }
            set { this._privateIp = value; }
        }

        // Check to see if PrivateIp property is set
        internal bool IsSetPrivateIp()
        {
            return this._privateIp != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The instance's public IP address.
        /// </para>
        /// </summary>
        public string PublicIp
        {
            get { return this._publicIp; }
            set { this._publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this._publicIp != null;
        }

        /// <summary>
        /// Gets and sets the property RsaPublicKey. 
        /// <para>
        /// The instances public RSA key. This key is used to encrypt communication between the
        /// instance and the service.
        /// </para>
        /// </summary>
        public string RsaPublicKey
        {
            get { return this._rsaPublicKey; }
            set { this._rsaPublicKey = value; }
        }

        // Check to see if RsaPublicKey property is set
        internal bool IsSetRsaPublicKey()
        {
            return this._rsaPublicKey != null;
        }

        /// <summary>
        /// Gets and sets the property RsaPublicKeyFingerprint. 
        /// <para>
        /// The instances public RSA key fingerprint.
        /// </para>
        /// </summary>
        public string RsaPublicKeyFingerprint
        {
            get { return this._rsaPublicKeyFingerprint; }
            set { this._rsaPublicKeyFingerprint = value; }
        }

        // Check to see if RsaPublicKeyFingerprint property is set
        internal bool IsSetRsaPublicKeyFingerprint()
        {
            return this._rsaPublicKeyFingerprint != null;
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The ID of the stack that the instance is to be registered with.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}