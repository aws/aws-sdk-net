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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This structure contains information about the OpenSearch Service workspace used for
    /// this integration. An OpenSearch Service workspace is the collection of dashboards
    /// along with other OpenSearch Service tools. This workspace was created automatically
    /// as part of the integration setup. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/application.html">Centralized
    /// OpenSearch user interface (Dashboards) with OpenSearch Service</a>.
    /// </summary>
    public partial class OpenSearchWorkspace
    {
        private OpenSearchResourceStatus _status;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This structure contains information about the status of an OpenSearch Service resource.
        /// </para>
        /// </summary>
        public OpenSearchResourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of this workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}