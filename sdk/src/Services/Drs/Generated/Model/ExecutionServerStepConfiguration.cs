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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Configuration for a <c>SERVER</c> type execution step.
    /// </summary>
    public partial class ExecutionServerStepConfiguration
    {
        private List<RecoveryPlanExecutionServer> _servers = AWSConfigs.InitializeCollections ? new List<RecoveryPlanExecutionServer>() : null;

        /// <summary>
        /// Gets and sets the property Servers. 
        /// <para>
        /// The list of servers in this execution step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<RecoveryPlanExecutionServer> Servers
        {
            get { return this._servers; }
            set { this._servers = value; }
        }

        // Check to see if Servers property is set
        internal bool IsSetServers()
        {
            return this._servers != null && (this._servers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}