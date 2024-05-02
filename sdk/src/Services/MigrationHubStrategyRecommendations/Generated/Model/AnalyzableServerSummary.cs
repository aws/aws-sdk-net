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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
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
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Summary information about an analyzable server.
    /// </summary>
    public partial class AnalyzableServerSummary
    {
        private string _hostname;
        private string _ipAddress;
        private string _source;
        private string _vmId;

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// The host name of the analyzable server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The ip address of the analyzable server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The data source of the analyzable server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property VmId. 
        /// <para>
        /// The virtual machine id of the analyzable server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string VmId
        {
            get { return this._vmId; }
            set { this._vmId = value; }
        }

        // Check to see if VmId property is set
        internal bool IsSetVmId()
        {
            return this._vmId != null;
        }

    }
}