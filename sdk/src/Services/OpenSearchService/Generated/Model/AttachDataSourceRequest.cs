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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the parameters to the AttachDataSource operation.
    /// Attaches a data source to an OpenSearch application. The data source can be an Amazon
    /// OpenSearch Service domain or an Amazon OpenSearch Serverless collection. If both the
    /// application and data source are in the <c>ACTIVE</c> state, the attachment completes
    /// immediately and returns a status of <c>ATTACHED</c>. If either resource is not yet
    /// active, the operation stores the request and returns a status of <c>PENDING</c>. A
    /// background process then completes the attachment when both resources become active.
    /// Pending attachments that are not completed within 24 hours are marked as <c>FAILED</c>.
    /// This operation is idempotent. If a data source is already attached or pending for
    /// the same application, the existing attachment is returned.
    /// </summary>
    public partial class AttachDataSourceRequest : AmazonOpenSearchServiceRequest
    {
        private string _clientToken;
        private string _dataSourceArn;
        private string _id;
        private WorkspaceConfigurationInput _workspaceConfiguration;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request. If you retry
        /// a request with the same client token and the same parameters, the retry succeeds without
        /// performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceArn.
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DataSourceArn
        {
            get { return this._dataSourceArn; }
            set { this._dataSourceArn = value; }
        }

        // Check to see if DataSourceArn property is set
        internal bool IsSetDataSourceArn()
        {
            return this._dataSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier or name of the OpenSearch application to attach the data source
        /// to. This is the same identifier used with <c>UpdateApplication</c>, <c>GetApplication</c>,
        /// and <c>DeleteApplication</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceConfiguration. 
        /// <para>
        /// Configuration for creating a new workspace during the attachment. If specified, a
        /// workspace is created and linked to the data source after the attachment completes.
        /// Mutually exclusive with <c>workspaceId</c>.
        /// </para>
        /// </summary>
        public WorkspaceConfigurationInput WorkspaceConfiguration
        {
            get { return this._workspaceConfiguration; }
            set { this._workspaceConfiguration = value; }
        }

        // Check to see if WorkspaceConfiguration property is set
        internal bool IsSetWorkspaceConfiguration()
        {
            return this._workspaceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The identifier of an existing workspace to update with the new data source. Mutually
        /// exclusive with <c>workspaceConfiguration</c>.
        /// </para>
        /// </summary>
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