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
    /// Container for the parameters to the CreateBackup operation.
    /// Creates an application-level backup of a server. While the server is <code>BACKING_UP</code>,
    /// the server can not be modified and no additional backup can be created. 
    /// 
    ///  
    /// <para>
    ///  Backups can be created for <code>RUNNING</code>, <code>HEALTHY</code> and <code>UNHEALTHY</code>
    /// servers. 
    /// </para>
    ///  
    /// <para>
    ///  This operation is asnychronous. 
    /// </para>
    ///  
    /// <para>
    ///  By default 50 manual backups can be created. 
    /// </para>
    ///  
    /// <para>
    ///  A <code>LimitExceededException</code> is thrown then the maximum number of manual
    /// backup is reached. A <code>InvalidStateException</code> is thrown when the server
    /// is not in any of RUNNING, HEALTHY, UNHEALTHY. A <code>ResourceNotFoundException</code>
    /// is thrown when the server is not found. A <code>ValidationException</code> is thrown
    /// when parameters of the request are not valid. 
    /// </para>
    /// </summary>
    public partial class CreateBackupRequest : AmazonOpsWorksCMRequest
    {
        private string _description;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A user-defined description of the backup. 
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server that you want to back up. 
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