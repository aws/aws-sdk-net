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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
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
namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// This is the response object from the ListPendingMaintenanceActions operation.
    /// </summary>
    public partial class ListPendingMaintenanceActionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ResourcePendingMaintenanceAction> _resourcePendingMaintenanceActions = AWSConfigs.InitializeCollections ? new List<ResourcePendingMaintenanceAction>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// displayed, the responses will include only records beyond the marker, up to the value
        /// specified by <c>maxResults</c>.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePendingMaintenanceActions. 
        /// <para>
        /// Provides information about a pending maintenance action for a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResourcePendingMaintenanceAction> ResourcePendingMaintenanceActions
        {
            get { return this._resourcePendingMaintenanceActions; }
            set { this._resourcePendingMaintenanceActions = value; }
        }

        // Check to see if ResourcePendingMaintenanceActions property is set
        internal bool IsSetResourcePendingMaintenanceActions()
        {
            return this._resourcePendingMaintenanceActions != null && (this._resourcePendingMaintenanceActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}