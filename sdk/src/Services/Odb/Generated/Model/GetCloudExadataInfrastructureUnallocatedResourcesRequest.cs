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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the GetCloudExadataInfrastructureUnallocatedResources operation.
    /// Retrieves information about unallocated resources in a specified Cloud Exadata Infrastructure.
    /// </summary>
    public partial class GetCloudExadataInfrastructureUnallocatedResourcesRequest : AmazonOdbRequest
    {
        private string _cloudExadataInfrastructureId;
        private List<string> _dbServers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructureId. 
        /// <para>
        /// The unique identifier of the Cloud Exadata infrastructure for which to retrieve unallocated
        /// resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string CloudExadataInfrastructureId
        {
            get { return this._cloudExadataInfrastructureId; }
            set { this._cloudExadataInfrastructureId = value; }
        }

        // Check to see if CloudExadataInfrastructureId property is set
        internal bool IsSetCloudExadataInfrastructureId()
        {
            return this._cloudExadataInfrastructureId != null;
        }

        /// <summary>
        /// Gets and sets the property DbServers. 
        /// <para>
        /// The database servers to include in the unallocated resources query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> DbServers
        {
            get { return this._dbServers; }
            set { this._dbServers = value; }
        }

        // Check to see if DbServers property is set
        internal bool IsSetDbServers()
        {
            return this._dbServers != null && (this._dbServers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}