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
    /// Container for the parameters to the StartMaintenance operation.
    /// Manually starts server maintenance. This command can be useful if an earlier maintenance
    /// attempt failed, and the underlying cause of maintenance failure has been resolved.
    /// The server will switch to <code>UNDER_MAINTENANCE</code> state, while maintenace is
    /// in progress. 
    /// 
    ///  
    /// <para>
    ///  Maintenace can only be started for <code>HEALTHY</code> and <code>UNHEALTHY</code>
    /// servers. A <code>InvalidStateException</code> is thrown otherwise. A <code>ResourceNotFoundException</code>
    /// is thrown when the server does not exist. A <code>ValidationException</code> is raised
    /// when parameters of the request are invalid. 
    /// </para>
    /// </summary>
    public partial class StartMaintenanceRequest : AmazonOpsWorksCMRequest
    {
        private string _serverName;

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server on which to run maintenance. 
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