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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDeleteAgents operation.
    /// Deletes one or more agents or collectors as specified by ID. Deleting an agent or
    /// collector does not delete the previously discovered data. To delete the data collected,
    /// use <c>StartBatchDeleteConfigurationTask</c>.
    /// </summary>
    public partial class BatchDeleteAgentsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<DeleteAgent> _deleteAgents = AWSConfigs.InitializeCollections ? new List<DeleteAgent>() : null;

        /// <summary>
        /// Gets and sets the property DeleteAgents. 
        /// <para>
        ///  The list of agents to delete. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<DeleteAgent> DeleteAgents
        {
            get { return this._deleteAgents; }
            set { this._deleteAgents = value; }
        }

        // Check to see if DeleteAgents property is set
        internal bool IsSetDeleteAgents()
        {
            return this._deleteAgents != null && (this._deleteAgents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}