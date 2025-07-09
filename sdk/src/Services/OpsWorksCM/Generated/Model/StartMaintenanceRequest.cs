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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the StartMaintenance operation.
    /// Manually starts server maintenance. This command can be useful if an earlier maintenance
    /// attempt failed, and the underlying cause of maintenance failure has been resolved.
    /// The server is in an <c>UNDER_MAINTENANCE</c> state while maintenance is in progress.
    /// 
    /// 
    ///  
    /// <para>
    ///  Maintenance can only be started on servers in <c>HEALTHY</c> and <c>UNHEALTHY</c>
    /// states. Otherwise, an <c>InvalidStateException</c> is thrown. A <c>ResourceNotFoundException</c>
    /// is thrown when the server does not exist. A <c>ValidationException</c> is raised when
    /// parameters of the request are not valid. 
    /// </para>
    /// </summary>
    public partial class StartMaintenanceRequest : AmazonOpsWorksCMRequest
    {
        private List<EngineAttribute> _engineAttributes = AWSConfigs.InitializeCollections ? new List<EngineAttribute>() : null;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property EngineAttributes. 
        /// <para>
        /// Engine attributes that are specific to the server on which you want to run maintenance.
        /// </para>
        ///  
        /// <para>
        ///  <b>Attributes accepted in a StartMaintenance request for Chef</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CHEF_MAJOR_UPGRADE</c>: If a Chef Automate server is eligible for upgrade to Chef
        /// Automate 2, add this engine attribute to a <c>StartMaintenance</c> request and set
        /// the value to <c>true</c> to upgrade the server to Chef Automate 2. For more information,
        /// see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/opscm-a2upgrade.html">Upgrade
        /// an OpsWorks for Chef Automate Server to Chef Automate 2</a>. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EngineAttribute> EngineAttributes
        {
            get { return this._engineAttributes; }
            set { this._engineAttributes = value; }
        }

        // Check to see if EngineAttributes property is set
        internal bool IsSetEngineAttributes()
        {
            return this._engineAttributes != null && (this._engineAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server on which to run maintenance. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
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