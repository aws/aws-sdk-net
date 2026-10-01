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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Hostname. The host name of the analyzable server.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Hostname { get; set; }

        /// <summary>
        /// Checks to see if the Hostname property is set.
        /// </summary>
        internal bool IsSetHostname() => this.Hostname != null;

        /// <summary>
        /// Gets and sets the property IpAddress. The ip address of the analyzable server.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property Source. The data source of the analyzable server.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property VmId. The virtual machine id of the analyzable server.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string VmId { get; set; }

        /// <summary>
        /// Checks to see if the VmId property is set.
        /// </summary>
        internal bool IsSetVmId() => this.VmId != null;
    }
}
