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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreServer operation.
    /// Restores a backup to a server that is in a <code>RUNNING</code>, <code>FAILED</code>,
    /// or <code>HEALTHY</code> state. When you run RestoreServer, the server's EC2 instance
    /// is deleted, and a new EC2 instance is configured. RestoreServer maintains the existing
    /// server endpoint, so configuration management of all of the server's client devices
    /// should continue to work. 
    /// 
    ///  
    /// <para>
    ///  This operation is asynchronous. 
    /// </para>
    ///  
    /// <para>
    ///  A <code>InvalidStateException</code> is thrown when the server is not in a valid
    /// state. A <code>ResourceNotFoundException</code> is thrown when the server does not
    /// exist. A <code>ValidationException</code> is raised when parameters of the request
    /// are invalid. 
    /// </para>
    /// </summary>
    public partial class RestoreServerRequest : AmazonOpsWorksCMRequest
    {
        private string _backupId;
        private string _instanceType;
        private string _keyPair;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        ///  The ID of the backup that you want to use to restore a server. 
        /// </para>
        /// </summary>
        public string BackupId
        {
            get { return this._backupId; }
            set { this._backupId = value; }
        }

        // Check to see if BackupId property is set
        internal bool IsSetBackupId()
        {
            return this._backupId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///  The type of the instance to create. Valid values must be specified in the following
        /// format: <code>^([cm][34]|t2).*</code> For example, <code>c3.large</code>. If you do
        /// not specify this parameter, RestoreServer uses the instance type from the specified
        /// backup. 
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property KeyPair. 
        /// <para>
        ///  The name of the key pair to set on the new EC2 instance. This can be helpful if any
        /// of the administrators who manage the server no longer have the SSH key. 
        /// </para>
        /// </summary>
        public string KeyPair
        {
            get { return this._keyPair; }
            set { this._keyPair = value; }
        }

        // Check to see if KeyPair property is set
        internal bool IsSetKeyPair()
        {
            return this._keyPair != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        ///  The name of the server that you want to restore. 
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

    }
}